using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11demo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person p = new Person();
            //p.Id = 1;
            //p.Name = "肖自翔";
            //p.Password = "123456";
            //Console.WriteLine(p.Id+p.Name+p.Password);
            //Console.ReadKey();

            String str = "ab_ cc  == be";
            String path = @"c:\\abc\s\d\\be\\d\苍老师.wav";
            String path1=path.Substring(path.LastIndexOf("\\")+1);
            Console.WriteLine(path1);
            str = str.Replace("b", "*");
            char[] chs = {' ', '_', '='};
           String[] sp= str.Split(chs, StringSplitOptions.None);
           for (int i = 0; i < sp.Length; i++)
           {
               Console.Write(sp[i]);
           }

           Console.ReadKey();
        }
    }
}
