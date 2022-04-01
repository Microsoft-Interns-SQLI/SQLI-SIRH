using Microsoft.AspNetCore.Identity;

namespace API_MySIRH.Entities.Auth
{
    public class User : IdentityUser<int>
    {
        public ICollection<UserRole> UserRoles { get; set; }
    }
}
