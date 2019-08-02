using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoffeeShopApp.Models;
using Microsoft.EntityFrameworkCore;

namespace CoffeeShopApp.Data
{
    public class CoffeeShopDbContext : DbContext
    {
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Reservation> Type { get; set; }
    }
}
