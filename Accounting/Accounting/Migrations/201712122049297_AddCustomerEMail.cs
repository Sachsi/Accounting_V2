namespace Accounting.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCustomerEMail : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "EMail", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "EMail");
        }
    }
}
