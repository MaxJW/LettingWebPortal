using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using LWCustomer.Data;

namespace LWCustomer.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ApplicationDbContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<ApplicationDbContext>>()))
            {
                // Look for any movies.
                if (context.Property.Any())
                {
                    return;   // DB has been seeded
                }

                context.Property.AddRange(
                    new Property
                    {
                        Address = "1 Chapel Road",
                        Location = "Dundee",
                        Description = "3 bedroom house, excellent views of the surrounding area. Plenty of area for expansion.",
                        Price = 625
                    },

                    new Property
                    {
                        Address = "2 Place Street",
                        Location = "Edinburgh",
                        Description = "3 bedroom house, excellent views of the surrounding area. Plenty of area for expansion.",
                        Price = 800
                    },

                    new Property
                    {
                        Address = "3 Somewhere Lane",
                        Location = "Glasgow",
                        Description = "3 bedroom house, excellent views of the surrounding area. Plenty of area for expansion.",
                        Price = 785
                    },

                    new Property
                    {
                        Address = "18 Flat Place",
                        Location = "Aberdeen",
                        Description = "3 bedroom house, excellent views of the surrounding area. Plenty of area for expansion.",
                        Price = 680
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
