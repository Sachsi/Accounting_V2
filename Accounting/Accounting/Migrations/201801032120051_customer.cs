namespace Accounting.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class customer : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customer",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FullName = c.String(name: "Full Name", maxLength: 100),
                        EMailAddress = c.String(name: "E-Mail Address", maxLength: 100),
                        PhoneNumber = c.Int(name: "Phone Number", nullable: false),
                        CSA = c.Boolean(nullable: false),
                        Neightbarhood = c.Boolean(nullable: false),
                        HorsBarn = c.Boolean(name: "Hors Barn", nullable: false),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Customer");
        }
    }
}
