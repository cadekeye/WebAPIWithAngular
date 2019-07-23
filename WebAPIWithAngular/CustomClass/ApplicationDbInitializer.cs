using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAPIWithAngular.Models;

namespace WebAPIWithAngular.CustomClass
{
    public class ApplicationDbInitializer: System.Data.Entity.DropCreateDatabaseIfModelChanges<ApplicationDbContext>
    {
        protected override void Seed(ApplicationDbContext context)
        {
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