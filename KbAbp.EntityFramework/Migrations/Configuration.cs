using System.Data.Entity.Migrations;

namespace KbAbp.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<KbAbp.EntityFramework.KbAbpDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "KbAbp";
        }

        protected override void Seed(KbAbp.EntityFramework.KbAbpDbContext context)
        {
            // This method will be called every time after migrating to the latest version.
            // You can add any seed data here...
        }
    }
}
