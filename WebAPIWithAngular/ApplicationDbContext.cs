using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebAPIWithAngular.CustomClass;
using WebAPIWithAngular.Models;

namespace WebAPIWithAngular
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext() : base("DBConn")
        {
            Database.SetInitializer<ApplicationDbContext>(new ApplicationDbInitializer());
        }
        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public DbSet<SugarLevel> SugarLevels { get; set; }
    }
}