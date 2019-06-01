using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09demo
{

    //申明枚举
    public enum sex { 
        男,
        女
    }


    class Program
    {
        static void Main(string[] args)
        {
            //int sum = 0;
            //for (int i = 1; i <= 100; i++) {
            //     sum += i;
            //    if (sum >= 20) {
            //        Console.WriteLine(i);
            //        break;
            //    }
            //}
            //Console.ReadKey();

            //String username = "";
            //String password = "";
            //while (username != "admin" || password != "8888") {
            //    Console.WriteLine("请输入用户名：");
            //    username = Console.ReadLine();
            //    Console.WriteLine("请输入密码:");
            //    password = Console.ReadLine();
            //    if (username.Equals("admin") && password.Equals("8888"))
            //    {
            //        Console.WriteLine("登录成功");
            //    }
            //    else {
            //        Console.WriteLine("请重新登录");
            //    }
            //}
            //Console.ReadKey();


            //求1-100之间的质数
            //for (int i = 2; i <=100; i++)//6 7 8
            //{
            //    bool b = true;
            //    for (int j =2; j < i; j++)
            //    {
            //        if (i % j == 0) {
            //            b = false;
            //            break;
            //        }
            //    }
            //    if (b == true) {
            //        Console.WriteLine(i);
            //    }
                
            //}
            //Console.ReadKey();

            //产生随机数
            //Random r = new Random();
            //while (true) {
            //    int rnumber = r.Next(1,11);
            //    Console.WriteLine(rnumber);
            //    Console.ReadKey();
            //}
            String s="0";
           sex s1=(sex)Enum.Parse(typeof(sex), s);
           Console.WriteLine(s1);
           Console.ReadKey();

           
        }
    }
}
