namespace Accounting.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addProduceTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Produces",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ProduceName = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            AddColumn("dbo.Incomes", "Proudces_ID", c => c.Int(defaultValue: 1));
            CreateIndex("dbo.Incomes", "Proudces_ID");
            AddForeignKey("dbo.Incomes", "Proudces_ID", "dbo.Produces", "ID");
            DropColumn("dbo.Incomes", "Date");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Incomes", "Date", c => c.DateTime(nullable: false));
            DropForeignKey("dbo.Incomes", "Proudces_ID", "dbo.Produces");
            DropIndex("dbo.Incomes", new[] { "Proudces_ID" });
            DropColumn("dbo.Incomes", "Proudces_ID");
            DropTable("dbo.Produces");
        }
    }
}
