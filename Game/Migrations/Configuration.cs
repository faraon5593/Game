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
            AutomaticMigrationsEnabled = false;
            ContextKey = "Game.Models.dbContext";
        }

        protected override void Seed(Game.Models.dbContext context)
        {
            
                context.Budynki.AddOrUpdate(                 
                    p => p.ID,
                    new Buildings { Name = "Tartak", Height = 2, Width = 2, Price = 100, Destr_price = 30, Percent_price_per_lvl = 110, Percent_product_per_lvl = 120, Product_per_h = 10},
                    new Buildings { Name = "Kopalnia wêgla", Height = 3, Width = 3, Price = 1000, Destr_price = 200, Percent_price_per_lvl = 120, Percent_product_per_lvl = 130, Product_per_h = 10}
               );

        }
    }
}
