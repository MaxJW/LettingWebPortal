using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using LettingWeb.Data;
using System;
using System.Linq;

namespace LettingWeb.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new LettingWebContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<LettingWebContext>>()))
            {
                // Look for any movies.
                if (context.Property.Any())
                {
                    return;   // DB has been seeded
                }

                context.Property.AddRange(
                    new Property
                    {
                        Address = "1 Place Road, Dundee",
                        Description = "Luxury 2 bedroom flat situated in a well maintained modern apartment block in the heart of Dundee City Centre, conveniently located for access to Dundee Universities, shops, bars and restaurants.",
                        Price = 855
                    },

                    new Property
                    {
                        Address = "16 Old Street, Longforgan",
                        Description = "Charming, one bedroom cottage situated in the sought after village of Longforgan",
                        Price = 625
                    },

                    new Property
                    {
                        Address = "23C Main Place",
                        Description = "Tidy, furnished, second floor furnished one bedroom flat with boxroom/spare bedroom/study. Available now.",
                        Price = 825
                    },

                    new Property
                    {
                        Address = "123 ABC Road",
                        Description = "Tiny 2 bedroom flat on busy street, please rent here",
                        Price = 108
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
