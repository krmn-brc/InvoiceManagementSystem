

using Entities.Models.Identities;
using Microsoft.AspNetCore.Identity;

namespace MvcApp.Infrastructure.Extensions
{
    public static class ApplicationExtensions
    {
         public static async void ConfigureDefaultAdminUserAsync(this IApplicationBuilder app)
        {
            const string adminUser = "Admin";
            const string password = "Admin+123456";

            // UserManager
            UserManager<AppUser> userManager =
            app.ApplicationServices
            .CreateScope()
            .ServiceProvider
            .GetRequiredService<UserManager<AppUser>>();

            // RoleManager
            RoleManager<AppRole> roleManager = app
            .ApplicationServices
            .CreateScope()
            .ServiceProvider
            .GetRequiredService<RoleManager<AppRole>>();
            AppUser? user = await userManager.FindByNameAsync(adminUser);
            if(user is null)
            {
                user = new AppUser()
                {
                    Email = "admin@admin.com",
                    PhoneNumber = "5351112233",
                    UserName = adminUser,
                    FirstName = "Admin",
                    LastName = "Management",
                    NationalyId = 00000000001
                };
                
                var result = await userManager.CreateAsync(user, password);
                if(!result.Succeeded)
                {
                    throw new Exception("Admin user could not created.");
                }
                var roleResult = await userManager.AddToRolesAsync(user, roleManager.Roles.Select(x => x.Name).ToList());

                if(!roleResult.Succeeded)
                    throw new Exception("System have problems with role defination for Admin.");
            }
        }
    }
}