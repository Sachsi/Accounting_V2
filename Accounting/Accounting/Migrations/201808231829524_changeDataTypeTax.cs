namespace Accounting.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changeDataTypeTax : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Expanses", "GST", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Expanses", "PST", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Expanses", "PST", c => c.Int(nullable: false));
            AlterColumn("dbo.Expanses", "GST", c => c.Int(nullable: false));
        }
    }
}
