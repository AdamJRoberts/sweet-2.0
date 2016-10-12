namespace WebApplication4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    using IdentitySample.Models;
    using System.Web;
    using Microsoft.AspNet.Identity.Owin;
    using Microsoft.AspNet.Identity;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<IdentitySample.Models.ApplicationDbContext>
    {
        private readonly bool _pendingMigrations;

        public Configuration()
        {
            // If you want automatic migrations the uncomment the line below.
            AutomaticMigrationsEnabled = true;
            var migrator = new DbMigrator(this);
            _pendingMigrations = migrator.GetPendingMigrations().Any();
        }

        protected override void Seed(ApplicationDbContext context)
        {
            //Microsoft comment says "This method will be called after migrating to the latest version."
            //However my testing shows that it is called every time the software starts

            //Exit if there aren't any pending migrations
            if (!_pendingMigrations) return;

            //else run your code to seed the database, e.g.
            ApplicationDbInitializer initializer = new ApplicationDbInitializer();
        }
    }
}
