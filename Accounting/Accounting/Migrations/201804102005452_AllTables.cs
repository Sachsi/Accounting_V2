namespace Accounting.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AllTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customer",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FullName = c.String(name: "Full Name",nullable: false, maxLength: 100),
                        EMailAddress = c.String(name: "E-Mail Address", maxLength: 100),
                        PhoneNumber = c.String(name: "Phone Number", maxLength: 50),
                        CSA = c.Boolean(nullable: false),
                        Neightbarhood = c.Boolean(nullable: false),
                        HorsBarn = c.Boolean(name: "Hors Barn", nullable: false),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Income",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        Payment = c.String(maxLength: 20),
                        Price = c.Double(nullable: false),
                        Products = c.String(),
                        Customer_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customer", t => t.Customer_Id)
                .Index(t => t.Customer_Id);
            
            CreateTable(
                "dbo.Expanses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        Dealer = c.String(maxLength: 30),
                        Payment = c.String(maxLength: 10),
                        Price = c.Double(nullable: false),
                        Details = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Produkts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        Farmer = c.String(maxLength: 30),
                        Produce = c.String(maxLength: 20),
                        Price = c.Double(nullable: false),
                        Unit = c.Int(nullable: false),
                        Quantity = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Income", "Customer_Id", "dbo.Customer");
            DropIndex("dbo.Income", new[] { "Customer_Id" });
            DropTable("dbo.Produkts");
            DropTable("dbo.Expanses");
            DropTable("dbo.Income");
            DropTable("dbo.Customer");
        }
    }
}
