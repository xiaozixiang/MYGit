using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02demo
{ 
    class Program 
    {
        static void Main(string[] args)
        {
            //编程实现第46天是第几周零几天 
            //int today = 46;
            //int week = today / 7;
            //int day = today % 7;
            //Console.WriteLine("第四十六天是第{0}周零{1}天", week, day);
            //Console.ReadKey();

            Console.WriteLine("请输入天数");
            String d1 = Console.ReadLine();
            int d2 = Convert.ToInt32(d1);
            int d3 = d2 / 7;
            int d4 = d2 % 7;
            Console.WriteLine("第{0}天是第{1}周零{2}", d2, d3, d4);
            Console.ReadKey();

            //编程实现107653秒是几天几小时几分钟几秒
            Console.WriteLine("请输入多少秒 ");
            String s1 = Console.ReadLine();
            int s2 = Convert.ToInt32(s1);
            int s3 = s2 / (60 * 60 * 24);
            int s4 = (s2 % (60 * 60 * 24)) / (60 * 60);
            int s5 = ((s2 % (60 * 60 * 24)) %(60 * 60))/60;
            int s6 = ((s2 % (60 * 60 * 24)) % (60 * 60)) % 60;
            Console.WriteLine("{0}是{1}天{2}小时{3}分钟{4}秒",s2,s3,s4,s5,s6);
            Console.ReadKey();

        }
    }
}
