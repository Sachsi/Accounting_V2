namespace Accounting.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addColumeCustomer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customer", "E-Mail Address", c => c.String(maxLength: 100));
            AddColumn("dbo.Customer", "Phone Number", c => c.Int(nullable: false));
            AddColumn("dbo.Customer", "CSA", c => c.Boolean(nullable: false));
            AddColumn("dbo.Customer", "Neightbarhood", c => c.Boolean(nullable: false));
            AddColumn("dbo.Customer", "Hors Barn", c => c.Boolean(nullable: false));
            AddColumn("dbo.Customer", "Date", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customer", "Date");
            DropColumn("dbo.Customer", "Hors Barn");
            DropColumn("dbo.Customer", "Neightbarhood");
            DropColumn("dbo.Customer", "CSA");
            DropColumn("dbo.Customer", "Phone Number");
            DropColumn("dbo.Customer", "E-Mail Address");
        }
    }
}
