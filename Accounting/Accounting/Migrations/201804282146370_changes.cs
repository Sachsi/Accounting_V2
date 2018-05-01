namespace Accounting.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changes : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Produkts", "Quantity", c => c.Double(nullable: true));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Produkts", "Quantity", c => c.Int(nullable: true));
        }
    }
}
