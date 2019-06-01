using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08demo
{
    class Program
    {
        static void Main(string[] args)
        {

            //九九乘法表
            for (int i = 1; i <=9; i++)
            {
                for (int j = 1; j <=i; j++)
			    {
                    Console.Write("{0}*{1}={2}\t", i, j, i * j);
			    }
                Console.WriteLine();
            }
            Console.ReadKey();

            int number = 1;
           bool b= int.TryParse("123abc", out number);
           Console.WriteLine(b);
           Console.WriteLine(number);
           Console.ReadKey();
        }
    }
}
