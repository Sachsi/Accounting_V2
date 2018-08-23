namespace Accounting.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addTaxes : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Expanses", "GST", c => c.Int(nullable: false));
            AddColumn("dbo.Expanses", "PST", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Expanses", "PST");
            DropColumn("dbo.Expanses", "GST");
        }
    }
}
