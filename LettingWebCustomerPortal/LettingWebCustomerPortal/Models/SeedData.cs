using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using LettingWebCustomerPortal.Data;

namespace LettingWebCustomerPortal.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new LettingWebCustomerPortalContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<LettingWebCustomerPortalContext>>()))
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
                        Description = "Small 1 bedroom house with surrounding garden. Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua",
                        Price = 625
                    },

                    new Property
                    {
                        Address = "16 Main Street",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua",
                        Price = 800
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
