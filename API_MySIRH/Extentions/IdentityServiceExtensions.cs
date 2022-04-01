using API_MySIRH.Data;
using API_MySIRH.Entities.Auth;
using Microsoft.AspNetCore.Identity;

namespace API_MySIRH.Extentions
{
    public static class IdentityServiceExtensions
    {
        public static IServiceCollection AddIdentityServices(this IServiceCollection services)
        {
            services.AddIdentityCore<User>(op =>
            {
                op.Password.RequireNonAlphanumeric = false; 
                op.User.RequireUniqueEmail = true;
            })
                .AddRoles<Role>()
                .AddRoleManager<RoleManager<Role>>()
                .AddSignInManager<SignInManager<User>>()
                .AddRoleValidator<RoleValidator<Role>>()
                .AddEntityFrameworkStores<DataContext>();
            return services;
        }
    }
}
