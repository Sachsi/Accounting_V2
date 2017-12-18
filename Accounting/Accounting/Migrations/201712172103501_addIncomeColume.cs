namespace Accounting.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addIncomeColume : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Incomes", name: "CustomerName_ID", newName: "Customer_ID");
            RenameIndex(table: "dbo.Incomes", name: "IX_CustomerName_ID", newName: "IX_Customer_ID");
            AddColumn("dbo.Incomes", "Product", c => c.String());
            AddColumn("dbo.Incomes", "CustomerName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Incomes", "CustomerName");
            DropColumn("dbo.Incomes", "Product");
            RenameIndex(table: "dbo.Incomes", name: "IX_Customer_ID", newName: "IX_CustomerName_ID");
            RenameColumn(table: "dbo.Incomes", name: "Customer_ID", newName: "CustomerName_ID");
        }
    }
}
