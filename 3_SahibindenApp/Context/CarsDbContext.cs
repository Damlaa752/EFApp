using _3_SahibindenApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_SahibindenApp.Context
{
    internal class CarsDbContext : DbContext
    {
        public DbSet<Brand> Brands{ get; set; }
        public DbSet<Color> Colors{ get; set; }
        public DbSet<Car>Cars{ get; set; }

    }
}
