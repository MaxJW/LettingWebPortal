using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LettingWeb.Models;

namespace LettingWeb.Data
{
    public class LettingWebContext : DbContext
    {
        public LettingWebContext (DbContextOptions<LettingWebContext> options)
            : base(options)
        {
        }

        public DbSet<LettingWeb.Models.Property> Property { get; set; }
    }
}
