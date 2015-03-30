namespace Game.Migrations
{
    using Game.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Game.Models.dbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "Game.Models.dbContext";
        }

        protected override void Seed(Game.Models.dbContext context)
        {

            context.Budynki.AddOrUpdate(
              p => p.ID,
              new Buildings {  Name = "Tartak", Height = 2, Width = 2, Percent_price_per_lvl = 110, Percent_product_per_lvl = 120, Price = 1000, Destr_price = 100, Product_per_h = 10},
              new Buildings {  Name = "Kopalnia wêgla", Height = 3, Width = 3, Percent_price_per_lvl = 120, Percent_product_per_lvl = 130, Price = 5000, Destr_price = 1000, Product_per_h = 10},
              new Buildings {  Name = "Kopalnia z³ota", Height = 3, Width = 3, Percent_price_per_lvl = 130, Percent_product_per_lvl = 140, Price = 10000, Destr_price = 1000, Product_per_h = 10}
            );

            context.Produkty.AddOrUpdate(
              p => p.ID,
              new Products {  Name = "Drewno", Price_per_unit = 10, Unit = "m3"},
              new Products {  Name = "Wêgiel", Price_per_unit = 30, Unit = "t"},
              new Products {  Name = "Z³oto", Price_per_unit = 100, Unit = "kg" }
            );

            context.ProduktyUzytkownika.AddOrUpdate(
              p => p.ID,
              new UserProducts {  Product = context.Produkty.First(), Username = "admin", Value = 10}
            );
            
        }
    }
}
