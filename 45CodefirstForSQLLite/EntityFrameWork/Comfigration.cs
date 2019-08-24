using Microsoft.EntityFrameworkCore.Migrations;
using SQLite.CodeFirst;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _45CodefirstForSQLLite.EntityFrameWork
{
    public class Comfigration : DbMigrationsConfiguration<MyDbContext>
    {
        public Comfigration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
           // SetSqlGenerator("System.Data.SQLite", new SqliteMigrationsSqlGenerator());
        }
    }
}
