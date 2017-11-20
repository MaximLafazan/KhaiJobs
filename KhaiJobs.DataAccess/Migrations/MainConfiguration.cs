namespace KhaiJobs.DataAccess.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class MainConfiguration : DbMigrationsConfiguration<KhaiJobs.DataAccess.MainContext>
    {
        public MainConfiguration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(KhaiJobs.DataAccess.MainContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
