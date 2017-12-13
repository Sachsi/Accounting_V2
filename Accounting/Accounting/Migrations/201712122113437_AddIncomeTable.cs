namespace Accounting.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddIncomeTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Incomes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Price = c.Double(nullable: false),
                        CustomerName_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Customers", t => t.CustomerName_ID)
                .Index(t => t.CustomerName_ID);

            AddColumn("dbo.Customers", "Phone", c => c.Long(nullable: false, defaultValue: 001 ));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Incomes", "CustomerName_ID", "dbo.Customers");
            DropIndex("dbo.Incomes", new[] { "CustomerName_ID" });
            DropTable("dbo.Incomes");
        }
    }
}
