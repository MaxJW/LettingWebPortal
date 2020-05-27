using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LettingWebCustomerPortal.Models;

namespace LettingWebCustomerPortal.Data
{
    public class LettingWebCustomerPortalContext : DbContext
    {
        public LettingWebCustomerPortalContext(DbContextOptions<LettingWebCustomerPortalContext> options)
            : base(options)
        {
        }

        public DbSet<Property> Property { get; set; }
    }
}
