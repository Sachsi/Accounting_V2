namespace Accounting.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addExpenses : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Expanses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(name: "Date", nullable: false),
                        Dealer = c.String(name: "Dealer", maxLength: 30, nullable: true),
                        Payment = c.String(name: "Payment", maxLength: 10, nullable: true),
                        Price = c.Double(name: "Price", nullable: false, defaultValue: 0.00),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Expanses");
        }
    }
}
