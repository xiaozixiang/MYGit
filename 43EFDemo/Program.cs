using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _43EFDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            exerciseEntities objectentity = new exerciseEntities();
            //增
            //Person p=new Person(){Name="肖怿",Sex="女",Age=23,Height=171};
            //objectentity.Person.Add(p);
            //objectentity.SaveChanges();

            //删除
            //Person p1 = new Person { Id = 6 };
            ////将对象附加到对象管理器中
            //objectentity.Person.Attach(p1);
            //objectentity.Entry(p1).State = EntityState.Deleted;
            ////objectentity.Person.Remove(p1);
            //objectentity.SaveChanges();


            //改  -------------一定要对所有字段赋值
            //Person p2 = new Person { Id = 7, Name = "肖怿",Sex="女",Age=23, Height = 168 };
            //objectentity.Person.Attach(p2);
            //objectentity.Entry(p2).State = EntityState.Modified;
            //objectentity.SaveChanges();

            //查
            DbSet<Person> set = objectentity.Set<Person>();
            var result = from p in set.ToList()
                         select p;
            foreach (var item in result)
            {
                Console.WriteLine(item.Id + " " + item.Name + " " + item.Height);
              
            }
            Console.ReadKey(); 


        }
    }
}
