using Microsoft.EntityFrameworkCore;
using OnOnePageVuejs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnOnePageVuejs.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Product> products { get; set; }
    
    }
}
