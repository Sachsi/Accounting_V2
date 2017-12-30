namespace Accounting.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removecolumesProducts : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Incomes", "Products_ID", "dbo.Products");
            DropIndex("dbo.Incomes", new[] { "Products_ID" });
            DropColumn("dbo.Incomes", "Products_ID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Incomes", "Products_ID", c => c.Int());
            CreateIndex("dbo.Incomes", "Products_ID");
            AddForeignKey("dbo.Incomes", "Products_ID", "dbo.Products", "ID");
        }
    }
}
