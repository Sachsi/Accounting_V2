namespace Accounting.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Accounting.Database.AccountingDatabase>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Accounting.Database+AccountingDatabase";
        }

        protected override void Seed(Accounting.Database.AccountingDatabase context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
