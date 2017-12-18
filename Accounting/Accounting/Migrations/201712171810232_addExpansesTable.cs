namespace Accounting.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addExpansesTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Expanses",
                c => new
                    {
                        ExpansesId = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        payment = c.String(),
                        Price = c.Double(nullable: false),
                        recipient = c.String(),
                    })
                .PrimaryKey(t => t.ExpansesId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Expanses");
        }
    }
}
