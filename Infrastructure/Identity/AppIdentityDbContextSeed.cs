using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Core.Entities.Identity;

namespace Infrastructure.Identity
{
    public class AppIdentityDbContextSeed
    {
        public AppIdentityDbContextSeed()
        {
        }

        public static async Task SeedUserAsync(UserManager<AppUser> userManager)
        {
            if (!userManager.Users.Any())
            {
                var user = new AppUser
                {
                    DisplayName = "Bob",
                    Email = "bob@test.com",
                    UserName = "bob@test.com",
                    Address = new Address
                    {
                        FirstName = "Bob",
                        LastName = "Bobbity",
                        State = "10 the Street",
                        City = "New York",
                        Street = "NY",
                        Zipcode = "90210"

                    }
                };

                await userManager.CreateAsync(user, "Pa$$w0rd");
            }
        }
    }
}
