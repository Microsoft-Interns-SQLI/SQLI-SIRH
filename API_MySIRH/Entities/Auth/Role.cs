using Microsoft.AspNetCore.Identity;

namespace API_MySIRH.Entities.Auth
{
    public class Role : IdentityRole<int>
    {
        public ICollection<UserRole> UserRoles { get; set; }
    }
}
