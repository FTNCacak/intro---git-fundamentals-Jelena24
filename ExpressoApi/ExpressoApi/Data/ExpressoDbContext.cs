using ExpressoApi.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace ExpressoApi.Data
{
    public class ExpressoDbContext : DbContext
    {
        public DbSet<Menu> Menus { get; set; }
        public DbSet <SubMenu> SubMenus { get; set; }

        public DbSet<Reservation> Reservations { get; set; }
    }
}