using Core.Identity;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastrucure.Identity
{
    public class AppIdentityDbContextSeed
    {
        public static async Task SeedUserAsync(UserManager<AppUser> userManager)
        {
            if(!userManager.Users.Any())
            {
                var user = new AppUser
                {
                    DisplayName = "Abanoub",
                    Email = "abanoub@gmail.com",
                    UserName = "abanoub@gmail.com",
                    Address = new Address
                    {
                        FirstName = "Abanoub",
                        LastName = "Nabil",
                        Street = "Gomhorya",
                        City = "Assiut",
                        State = "EG",
                        ZipCode = "71111"

                    }
                };
                await userManager.CreateAsync(user, "P@ssw0rd");
            }
        }
    }
}
