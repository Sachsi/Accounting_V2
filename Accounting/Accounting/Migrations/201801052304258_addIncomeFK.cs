namespace Accounting.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addIncomeFK : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Income", "Id", "dbo.Customer");
            DropIndex("dbo.Income", new[] { "Id" });
            DropPrimaryKey("dbo.Income");
            AddColumn("dbo.Income", "Customer_Id", c => c.Int());
            AlterColumn("dbo.Income", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Income", "Id");
            CreateIndex("dbo.Income", "Customer_Id");
            AddForeignKey("dbo.Income", "Customer_Id", "dbo.Customer", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Income", "Customer_Id", "dbo.Customer");
            DropIndex("dbo.Income", new[] { "Customer_Id" });
            DropPrimaryKey("dbo.Income");
            AlterColumn("dbo.Income", "Id", c => c.Int(nullable: false));
            DropColumn("dbo.Income", "Customer_Id");
            AddPrimaryKey("dbo.Income", "Id");
            CreateIndex("dbo.Income", "Id");
            AddForeignKey("dbo.Income", "Id", "dbo.Customer", "Id");
        }
    }
}
