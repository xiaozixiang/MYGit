using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01mydemo
{

    public struct person {
        public int id;
        public String name;
        public String password;
    }
    class Program
    {
        static void Main(string[] args)
        {
            string strbuffer = string.Empty;
            for (int i = 0; i < 10; i++)
            {
                strbuffer = StringBulidDemo();
            }
            Console.WriteLine(strbuffer.Length); //输出 2890  按道理应该是 10*1000=10000

            //
           var  price = CommonUtil.formatStr("1.2", 9);
            var num = CommonUtil.formatStr("2", 6);
            Console.WriteLine(price+"----------------"+num);
            Console.ReadKey();

            person p;
            p.id = 0;
            p.name = "张三";

            String s1 = "C#";
            String s2 = "c#";
            if (s1.Equals(s2, StringComparison.OrdinalIgnoreCase)) {
                Console.WriteLine("一样");
            }

            String[] str = { "张三", "李四", "王五", "王平", "王样" };

            String str4 = "张三 王五 李四";
            String[] strnew=str4.Split(new char[]{' '}, StringSplitOptions.RemoveEmptyEntries);


            String s3=String.Join("|", str);
            Console.WriteLine(s3);

            p.password = "123456";
            Console.WriteLine(p.name);
            Console.ReadKey();

            //String name = "张三";
            //int age = 32;
            //String email = "973870677@qq.com";
            //decimal salary = 4500m;
            //Console.WriteLine("我叫{0}，我住在地球村,我今年{1}岁，我的邮箱是{2},我的工资是{3}", name, age, email, salary);
            //Console.ReadKey();

            //int n1 = 10;
            //int n2 = 20;
            ////第一种方式交换数值
            ////int temp;
            ////temp = n1;
            ////n1 = n2;
            ////n2 = temp;
            ////第二种方式交换数值
            //n1 = n1 - n2;
            //n2 = n1 + n2;
            //n1 = n2 - n1;
            //Console.WriteLine("交换后的数值n1是{0}，n2是{1}",n1,n2);
            //Console.ReadKey();


        }
        /// <summary>
        /// 测试StringBulider 和 StringBuffer 的性能  StringBuffer > StringBuilder
        /// </summary>
        public static string  StringBulidDemo()
        {
            Task<string> task = new Task<string>(()=> {

                StringBuilder stringBuilder = new StringBuilder();
                for (int i = 0; i < 1000; i++)
                {
                    stringBuilder.Append(i.ToString());
                }
                return stringBuilder.ToString();
            });
            task.Start();
            task.Wait(new TimeSpan(100));
            return task.Result;
        }

       


    }
    
}
