namespace Accounting.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addIncomeTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Income",
                c => new
                    {
                        Id = c.Int(nullable: false,identity: true),
                        Date = c.DateTime(name: "Date",nullable: false),
                        Payment = c.String(name: "Payment",maxLength: 20),
                        Price = c.Double(name: "Price",nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customer", t => t.Id)
                .Index(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Income", "Id", "dbo.Customer");
            DropIndex("dbo.Income", new[] { "Id" });
            DropTable("dbo.Income");
        }
    }
}
