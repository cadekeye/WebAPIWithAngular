namespace WebAPIWithAngular.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using WebAPIWithAngular.CustomClass;
    using WebAPIWithAngular.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<WebAPIWithAngular.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            Database.SetInitializer<ApplicationDbContext>(new ApplicationDbInitializer());
        }

        protected override void Seed(WebAPIWithAngular.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            var sugarLevels = new List<SugarLevel>()
            {
                new SugarLevel{ Description="Test", Id=1, MeasuredAt = DateTime.Now, Value=3},
                new SugarLevel{ Description="Cane", Id=2, MeasuredAt = DateTime.Now, Value=4},
                new SugarLevel{ Description="Chocolate", Id=3, MeasuredAt = DateTime.Now, Value=2},
                new SugarLevel{ Description="Sweet", Id=4, MeasuredAt = DateTime.Now, Value=7}

            };

            sugarLevels.ForEach(x => context.SugarLevels.Add(x));
            context.SaveChanges();
            // context.SugarLevels.ad
            base.Seed(context);
        }
    }
}
