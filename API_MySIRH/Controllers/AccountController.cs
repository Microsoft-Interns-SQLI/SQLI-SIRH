using API_MySIRH.Entities.Auth.Dtos.incoming;
using API_MySIRH.Entities.Auth.Dtos.outgoing;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace API_MySIRH.Controllers
{
    [Route("Api/[Controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleInManager;
        private readonly IConfiguration _configuration;

        public AccountController(UserManager<IdentityUser> userManager,RoleManager<IdentityRole> roleManager,IConfiguration configuration)
        {
            this._userManager = userManager;
            this._roleInManager = roleManager;
            this._configuration = configuration;
         }
        [HttpPost]
        [Route("Login")]
        public async Task<IActionResult> Login([FromBody] UserRequestLoginDto userLogin)
        {
            var user = await _userManager.FindByNameAsync(userLogin.username);
            if(user !=null && await _userManager.CheckPasswordAsync(user,userLogin.Password))
            {
                var userRoles = await _userManager.GetRolesAsync(user);

                var authClaims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,userLogin.username),
                    new Claim(JwtRegisteredClaimNames.Jti,Guid.NewGuid().ToString()),
                };
                foreach (var userRole in userRoles)
                {
                    authClaims.Add(new Claim(ClaimTypes.Role, userRole));
                }
                var token = GetToken(authClaims);

                return Ok(
                    new UserResponseLoginDto()
                    {
                        Token=token,
                        success = true,
                    });
            }
            else
            {
                //Password doesn't match
                return BadRequest(new UserResponseLoginDto()
                {
                    success = false,
                    Errors = new List<string>()
                        {
                            "invalid authentication Resquest"
                        }
                });
            }

        }

        private string GetToken(List<Claim> authClaims)
        {
            var jwtHandler = new JwtSecurityTokenHandler();
            var authSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:Secret"]));

            var token = new JwtSecurityToken(
                issuer: _configuration["JWT:ValidIssuer"],
                audience: _configuration["JWT:ValidAudience"],
                expires: DateTime.Now.AddHours(3),
                claims: authClaims,
                signingCredentials: new SigningCredentials(authSigningKey, SecurityAlgorithms.HmacSha256)
                );

           var jwtToken=jwtHandler.WriteToken(token);
           return jwtToken;
        }

    }
}
