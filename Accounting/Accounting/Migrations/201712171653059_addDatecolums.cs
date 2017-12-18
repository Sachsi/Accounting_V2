namespace Accounting.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addDatecolums : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Incomes", "Date", c => c.DateTime(nullable: false));
            AddColumn("dbo.Products", "Date", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "Date");
            DropColumn("dbo.Incomes", "Date");
        }
    }
}
