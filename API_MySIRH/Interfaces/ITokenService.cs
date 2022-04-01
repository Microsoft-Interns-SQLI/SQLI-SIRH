using API_MySIRH.Entities.Auth;

namespace API_MySIRH.Interfaces
{
    public interface ITokenService
    {
        Task<string> CreateToken(User user);
    }
}
