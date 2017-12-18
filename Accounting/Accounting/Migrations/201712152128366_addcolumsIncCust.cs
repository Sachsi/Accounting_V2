namespace Accounting.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addcolumsIncCust : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Incomes", "Proudces_ID", "dbo.Produces");
            DropIndex("dbo.Incomes", new[] { "Proudces_ID" });
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        ProductName = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            AddColumn("dbo.Customers", "Date", c => c.DateTime(nullable: false));
            AddColumn("dbo.Customers", "CSA", c => c.Boolean(nullable: false, defaultValue: false));
            AddColumn("dbo.Customers", "Neighborhood", c => c.Boolean(nullable: false, defaultValue: false));
            AddColumn("dbo.Customers", "Horse_Barn", c => c.Boolean(nullable: false, defaultValue: false));
            AddColumn("dbo.Incomes", "Date", c => c.DateTime(nullable: false));
            AddColumn("dbo.Incomes", "Payment", c => c.String(defaultValue: "Chash"));
            AddColumn("dbo.Incomes", "Products_ID", c => c.Int());
            CreateIndex("dbo.Incomes", "Products_ID");
            AddForeignKey("dbo.Incomes", "Products_ID", "dbo.Products", "ID");
            DropColumn("dbo.Incomes", "Proudces_ID");
            DropTable("dbo.Produces");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Produces",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ProduceName = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            AddColumn("dbo.Incomes", "Proudces_ID", c => c.Int());
            DropForeignKey("dbo.Incomes", "Products_ID", "dbo.Products");
            DropIndex("dbo.Incomes", new[] { "Products_ID" });
            DropColumn("dbo.Incomes", "Products_ID");
            DropColumn("dbo.Incomes", "Payment");
            DropColumn("dbo.Incomes", "Date");
            DropColumn("dbo.Customers", "Horse_Barn");
            DropColumn("dbo.Customers", "Neighborhood");
            DropColumn("dbo.Customers", "CSA");
            DropColumn("dbo.Customers", "Date");
            DropTable("dbo.Products");
            CreateIndex("dbo.Incomes", "Proudces_ID");
            AddForeignKey("dbo.Incomes", "Proudces_ID", "dbo.Produces", "ID");
        }
    }
}
