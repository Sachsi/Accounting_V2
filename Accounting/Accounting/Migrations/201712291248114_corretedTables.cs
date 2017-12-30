namespace Accounting.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class corretedTables : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Incomes", "CustomerName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Incomes", "CustomerName", c => c.String());
        }
    }
}
