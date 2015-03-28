namespace Game.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Buildings",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Price = c.Int(nullable: false),
                        Percent_price_per_lvl = c.Int(nullable: false),
                        Width = c.Int(nullable: false),
                        Height = c.Int(nullable: false),
                        Product_per_h = c.Int(nullable: false),
                        Destr_price = c.Int(nullable: false),
                        Percent_product_per_lvl = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.UserBuildings",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Username = c.String(),
                        X_pos = c.Int(nullable: false),
                        Y_pos = c.Int(nullable: false),
                        Lvl = c.Int(nullable: false),
                        Building_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Buildings", t => t.Building_ID)
                .Index(t => t.Building_ID);
            
            CreateTable(
                "dbo.Maps",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Username = c.String(),
                        Width = c.Int(nullable: false),
                        Height = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Price_per_unit = c.Int(nullable: false),
                        Unit = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.UserProducts",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Username = c.String(),
                        ProductName = c.String(),
                        Value = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserBuildings", "Building_ID", "dbo.Buildings");
            DropIndex("dbo.UserBuildings", new[] { "Building_ID" });
            DropTable("dbo.UserProducts");
            DropTable("dbo.Products");
            DropTable("dbo.Maps");
            DropTable("dbo.UserBuildings");
            DropTable("dbo.Buildings");
        }
    }
}
