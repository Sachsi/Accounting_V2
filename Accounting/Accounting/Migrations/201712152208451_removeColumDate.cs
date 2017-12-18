namespace Accounting.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removeColumDate : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Customers", "Date");
            DropColumn("dbo.Incomes", "Date");
            DropColumn("dbo.Products", "Date");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "Date", c => c.DateTime(nullable: false));
            AddColumn("dbo.Incomes", "Date", c => c.DateTime(nullable: false));
            AddColumn("dbo.Customers", "Date", c => c.DateTime(nullable: false));
        }
    }
}
