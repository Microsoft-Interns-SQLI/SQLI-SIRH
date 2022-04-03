using API_MySIRH.DTOs.Auth;
using API_MySIRH.Entities.Auth;
using API_MySIRH.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.IdentityModel.Tokens.Jwt;

namespace API_MySIRH.Controllers
{
    [Route("")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly RoleManager<Role> _roleManager;
        private IMapper _mapper;
        private ITokenService _tokenService;

        public AuthController(
            UserManager<User> userManage,
            SignInManager<User> signInManager,
            RoleManager<Role> roleManager,
            IMapper mapper,
            ITokenService tokenService)
        {
            _userManager = userManage;
            _signInManager = signInManager;
            _roleManager = roleManager;
            _mapper = mapper;
            _tokenService = tokenService;
        }

        [HttpPost("register")]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult<AuthResponse>> Register([FromBody] UserDto userDto)
        {
            
            if (await UserExist(userDto.Email))
                return BadRequest("User is already exist!");

            var user = _mapper.Map<User>(userDto);

            var result = await _userManager.CreateAsync(user, userDto.Password);

            if(!result.Succeeded)
                return BadRequest(result.Errors);

            var roleResult = await _userManager.AddToRoleAsync(user, "Manager");

            if(!roleResult.Succeeded)
                return BadRequest(roleResult.Errors);

            var token = await _tokenService.CreateToken(user);

            return new AuthResponse
            {
                accessToken = new JwtSecurityTokenHandler().WriteToken(token),
                expiration = token.ValidTo.Subtract(new DateTime(1970, 1, 1)).TotalMilliseconds.ToString(),
                user = _mapper.Map<UserDto>(user)
            };


        }

        private async Task<bool> UserExist(string email)
        {
            return await _userManager.Users.AnyAsync(u=>u.Email == email);
        }

        [HttpPost("login")]
        public async Task<ActionResult<AuthResponse>> Login([FromBody] LoginDto loginDto)
        {
            var user = await _userManager.FindByEmailAsync(loginDto.Email);

            if(user == null) return Unauthorized("User unfound!");

            var result = await _signInManager.CheckPasswordSignInAsync(user, loginDto.Password, false);

            if (!result.Succeeded)
            {
                return BadRequest("Email or password is invalid!");
            }
            var token = await _tokenService.CreateToken(user);
            return new AuthResponse
            {
                accessToken = new JwtSecurityTokenHandler().WriteToken(token),
                expiration = token.ValidTo.Subtract(new DateTime(1970,1,1)).TotalMilliseconds.ToString(),
                user = _mapper.Map<UserDto>(user)
            };
        }
    }
}
