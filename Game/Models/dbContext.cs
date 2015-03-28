using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Game.Models
{
    public class dbContext : DbContext
    {
        public DbSet<Buildings> Budynki { get; set; }
        public DbSet<Maps> Mapy { get; set; }
        public DbSet<Products> Produkty { get; set; }
        public DbSet<UserBuildings> BudynkiUzytkownika { get; set; }
        public DbSet<UserProducts> ProduktyUzytkownika { get; set; }

        public dbContext()
            :base ("DefaultConnection")
        {

        }
    }
}