using System.Data.Entity.Migrations;
using MTK.JanitorHelper.Migrations.SeedData;
using EntityFramework.DynamicFilters;

namespace MTK.JanitorHelper.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<JanitorHelper.EntityFramework.JanitorHelperDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "JanitorHelper";
        }

        protected override void Seed(JanitorHelper.EntityFramework.JanitorHelperDbContext context)
        {
            context.DisableAllFilters();
            new InitialDataBuilder(context).Build();
        }
    }
}
