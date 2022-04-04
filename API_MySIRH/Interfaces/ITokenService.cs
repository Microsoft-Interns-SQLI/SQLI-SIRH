using API_MySIRH.Entities.Auth;
using Microsoft.IdentityModel.Tokens;

namespace API_MySIRH.Interfaces
{
    public interface ITokenService
    {
        Task<SecurityToken> CreateToken(User user);
    }
}
