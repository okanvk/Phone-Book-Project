using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.PhoneBook.WebUILayer.IdentityEntities
{
    public static class SeedIdentity
    {
        public static async Task CreateIdentityUsers(IServiceProvider serviceprovider, IConfiguration configuration)
        {

            var userManager = serviceprovider.GetRequiredService<UserManager<CustomIdentityUser>>();
            var roleManager = serviceprovider.GetRequiredService<RoleManager<CustomIdentityRole>>();

            var username = configuration["Data:AdminUser:username"];
            var email = configuration["Data:AdminUser:email"];
            var password = configuration["Data:AdminUser:password"];
            var roleConfig = configuration["Data:AdminUser:role"];

            CustomIdentityUser user = new CustomIdentityUser
            {
                UserName = username,
                Email = email
            };

            IdentityResult result =
                userManager.CreateAsync(user, password).Result;

            if (result.Succeeded)
            {
                if (!roleManager.RoleExistsAsync(roleConfig).Result)
                {
                    CustomIdentityRole role = new CustomIdentityRole
                    {
                        Name = roleConfig
                    };

                    IdentityResult roleResult = roleManager.CreateAsync(role).Result;

                    if (roleResult.Succeeded)
                    {
                        await userManager.AddToRoleAsync(user, "Admin");
                    }
                }
            }

        }
    }
}
