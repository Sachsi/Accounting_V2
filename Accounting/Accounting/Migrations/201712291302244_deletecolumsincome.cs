namespace Accounting.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deletecolumsincome : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Incomes", name: "Products_ID", newName: "Product_ID");
            RenameIndex(table: "dbo.Incomes", name: "IX_Products_ID", newName: "IX_Product_ID");
            DropColumn("dbo.Incomes", "Date");
            DropColumn("dbo.Incomes", "Payment");
            DropColumn("dbo.Incomes", "Price");
            DropColumn("dbo.Incomes", "Product");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Incomes", "Product", c => c.String());
            AddColumn("dbo.Incomes", "Price", c => c.Double(nullable: false));
            AddColumn("dbo.Incomes", "Payment", c => c.String());
            AddColumn("dbo.Incomes", "Date", c => c.DateTime(nullable: false));
            RenameIndex(table: "dbo.Incomes", name: "IX_Product_ID", newName: "IX_Products_ID");
            RenameColumn(table: "dbo.Incomes", name: "Product_ID", newName: "Products_ID");
        }
    }
}
