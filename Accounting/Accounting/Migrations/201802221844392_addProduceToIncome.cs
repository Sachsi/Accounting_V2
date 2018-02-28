namespace Accounting.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addProduceToIncome : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Income", "Produces_Id", c => c.Int(name: "Produces"));
            CreateIndex("dbo.Income", "Produces_Id");
            AddForeignKey("dbo.Income", "Produces_Id", "dbo.Produkts", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Income", "Produces_Id", "dbo.Produkts");
            DropIndex("dbo.Income", new[] { "Produces_Id" });
            DropColumn("dbo.Income", "Produces_Id");
        }
    }
}
