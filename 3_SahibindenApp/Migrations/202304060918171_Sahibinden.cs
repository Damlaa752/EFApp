namespace _3_SahibindenApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Sahibinden : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Brands",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Cars",
                c => new
                    {
                        CarID = c.Int(nullable: false, identity: true),
                        Model = c.String(),
                        Year = c.DateTime(nullable: false),
                        Who = c.String(),
                        Price = c.Double(nullable: false),
                        ColorID = c.Int(nullable: false),
                        City = c.String(),
                    })
                .PrimaryKey(t => t.CarID);
            
            CreateTable(
                "dbo.Colors",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Colors");
            DropTable("dbo.Cars");
            DropTable("dbo.Brands");
        }
    }
}
