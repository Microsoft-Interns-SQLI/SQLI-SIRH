using Microsoft.AspNetCore.Identity;

namespace API_MySIRH.Entities.Auth
{
    public class UserRole : IdentityUserRole<int>
    {
        public User User { get; set; }

        public Role Role { get; set; }
    }
}
