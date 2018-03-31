namespace Accounting.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IncomeExpensas : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Income", "Products", c => c.String(name: "Products", nullable: false));
            AddColumn("dbo.Expanses", "Details", c => c.String(name: "Details", nullable: true));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Expanses", "Details");
            DropColumn("dbo.Income", "Products");
        }
    }
}
