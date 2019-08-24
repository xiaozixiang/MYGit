using _44CodeFirstDemo.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _44CodeFirstDemo
{
    class Program
    {
        static void Main(string[] args)
        {
           
            MyDbContext myDbContext = new MyDbContext();
            //创建数据库
           // myDbContext.Database.CreateIfNotExists();
            User user = new User() { Name = "肖自翔", Password = "123456" };

            Database.SetInitializer<MyDbContext>(null);
            myDbContext.User.Add(user);
            Catalog catalog = new Catalog() { ID = 1, Name = "asdf" };

            myDbContext.catalogs.Add(catalog);
            myDbContext.SaveChanges();
           
            Console.WriteLine("成功");
            Console.ReadKey();
        }
    }
}
