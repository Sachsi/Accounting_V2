namespace Accounting.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _new : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customer",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FullName = c.String(name: "Full Name", maxLength: 100, nullable: true),
                        EMailAddress = c.String(name: "E-Mail Address", maxLength: 100, nullable: true),
                        PhoneNumber = c.String(name: "Phone Number", maxLength: 50, nullable: true),
                        CSA = c.Boolean(nullable: true, defaultValue: false),
                        Neightbarhood = c.Boolean(nullable: true, defaultValue: false),
                        HorsBarn = c.Boolean(name: "Hors Barn", nullable: true, defaultValue: false),
                        Date = c.DateTime(nullable: true),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Income",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: true),
                        Payment = c.String(maxLength: 20, nullable: true),
                        Price = c.Double(nullable: false),
                        Customer_Id = c.Int(nullable: true),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customer", t => t.Customer_Id)
                .Index(t => t.Customer_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Income", "Customer_Id", "dbo.Customer");
            DropIndex("dbo.Income", new[] { "Customer_Id" });
            DropTable("dbo.Income");
            DropTable("dbo.Customer");
        }
    }
}
