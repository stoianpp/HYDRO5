namespace Data.Migrations
{
    using Data.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    public sealed class Configuration : DbMigrationsConfiguration<Data.ApplicationDbContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = false;
            this.AutomaticMigrationDataLossAllowed = false;
        }

        protected override void Seed(Data.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
                context.Countries.AddOrUpdate(
                  p => p.Name,
                  new Country { Name = "Bulgaria" },
                  new Country { Name = "Romania" },
                  new Country { Name = "Poland" },
                  new Country { Name = "Serbia" },
                  new Country { Name = "Bosnia" }
                );
            
        }
    }
}
