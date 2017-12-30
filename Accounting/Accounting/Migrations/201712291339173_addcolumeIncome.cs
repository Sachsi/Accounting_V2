namespace Accounting.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addcolumeIncome : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Incomes", name: "Product_ID", newName: "Products_ID");
            RenameIndex(table: "dbo.Incomes", name: "IX_Product_ID", newName: "IX_Products_ID");
            AddColumn("dbo.Incomes", "Date", c => c.DateTime(nullable: false));
            AddColumn("dbo.Incomes", "Payment", c => c.String());
            AddColumn("dbo.Incomes", "Price", c => c.Double(nullable: false));
            AddColumn("dbo.Incomes", "Product", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Incomes", "Product");
            DropColumn("dbo.Incomes", "Price");
            DropColumn("dbo.Incomes", "Payment");
            DropColumn("dbo.Incomes", "Date");
            RenameIndex(table: "dbo.Incomes", name: "IX_Products_ID", newName: "IX_Product_ID");
            RenameColumn(table: "dbo.Incomes", name: "Products_ID", newName: "Product_ID");
        }
    }
}
