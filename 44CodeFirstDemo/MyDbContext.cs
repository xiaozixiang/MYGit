using _44CodeFirstDemo.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _44CodeFirstDemo
{
    public class MyDbContext : DbContext
    {

        public DbSet<User> User {get;set;}

        public DbSet<Catalog> catalogs { get; set; }
        public MyDbContext():base("ConnetionString")
        {

        }
    }
}
