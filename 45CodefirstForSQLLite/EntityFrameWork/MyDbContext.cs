using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _45CodefirstForSQLLite.EntityFrameWork
{
    public class MyDbContext:DbContext
    {

        public MyDbContext():base("DefaultConnection")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<MyDbContext, Comfigration>());
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Configurations.AddFromAssembly(typeof(MyDbContext).Assembly);
      
        }
    }
}
