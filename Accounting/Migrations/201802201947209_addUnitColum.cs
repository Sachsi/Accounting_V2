namespace Accounting.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addUnitColum : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Produkts", "Unit", c => c.Int(name: "Unit", nullable: false, defaultValue: 1));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Produkts", "Unit");
        }
    }
}
