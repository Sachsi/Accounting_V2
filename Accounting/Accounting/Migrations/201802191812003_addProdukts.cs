namespace Accounting.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addProdukts : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Produkts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(name: "Date",nullable: false),
                        Farmer = c.String(name: "Farmer", maxLength: 30, defaultValue: "Pinsch of Soil"),
                        Produce = c.String(name: "Produce", maxLength: 20, defaultValue: "Veggie"),
                        Price = c.Double(name: "Price", nullable: false, defaultValue: 1.00),
                        Quantity = c.Int(name: "Quantity", nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Produkts");
        }
    }
}
