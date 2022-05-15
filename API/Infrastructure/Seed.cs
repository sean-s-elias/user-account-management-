using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Models;

namespace API.Infrastructure
{
    public class Seed
    {
        public static async Task SeedData(DataContext context)
        {
            if (context.Users.Any()) return;
            
            var users = new List<User>
            {
                new User
                {
                    Username = "Sean",
                    Password = "Password",
                    Firstname = "Sean",
                    Lastname = "Elias",
                    Email = "sean.elias@test.com",
                    Mobile = "044567198"
                },
                new User
                {
                    Username = "Charlotte",
                    Password = "Password",
                    Firstname = "Charlotte",
                    Lastname = "Elias",
                    Email = "charlotte.elias@test.com",
                    Mobile = "044567194"
                },
                new User
                {
                   Username = "Bob",
                   Password = "Password",
                   Firstname = "Bob",
                   Lastname = "User",
                   Email = "bob.user@test.com",
                   Mobile = "044567111"
                }
            };

            await context.Users.AddRangeAsync(users);
            await context.SaveChangesAsync();
        }
    }
}