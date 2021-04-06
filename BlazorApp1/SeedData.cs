using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorApp1.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace BlazorApp1
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ContactDbContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<ContactDbContext>>()))
            {
                // Look for any movies.
                if (context.Contacts.Any())
                {
                    return;   // DB has been seeded
                }

                context.Contacts.AddRange(
                    new Contact
                    {
                        FirstName = "Antony",
                        LastName = "Gordon",
                        BirthDate = DateTime.Today,
                        PhoneNumber = "555 555 5555"
                    });

                context.SaveChanges();
            }
        }
    }
}
