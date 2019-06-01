using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04demo
{
    class Program
    {
        static void Main(string[] args)
        {
            //请用户输入年份，在输入月份，输出该月份的天数

            int year = 0;
            int month = 0;
            bool b = true;
            Console.WriteLine("请输入年份");
            String stryear = Console.ReadLine();
            try
            {
                year = Convert.ToInt32(stryear);
            }
            catch {
                Console.WriteLine("输入年份错误");
                b = false;
                
            }
            if (b == true) {
                Console.WriteLine("在输入月份");
                String strmonth = Console.ReadLine();
                try
                {
                    month = Convert.ToInt32(strmonth);
                    //if (month > 12 || month <= 0) {
                    //    Console.WriteLine("月份输入错误");
                    //}
                }
                catch
                {
                    Console.WriteLine("输入错误");
                    b = false;
                }
            }


            if (b == true) {
                if ((year % 400 == 0) || (year % 4 == 0 && year % 100 != 0))
                {

                    switch (month)
                    {

                        case 1:
                        case 3:
                        case 5:
                        case 7:
                        case 8:
                        case 10:
                        case 12: Console.WriteLine("该月份有31天"); break;
                        case 2: Console.WriteLine("改月份有29天"); break;
                        case 4:
                        case 6:
                        case 9:
                        case 11: Console.WriteLine("改月份有30天"); break;
                        default:
                            {
                                Console.WriteLine("输入月份错误"); break;
                            }
                    }

                }
                else
                {
                    switch (month)
                    {

                        case 1:
                        case 3:
                        case 5:
                        case 7:
                        case 8:
                        case 10:
                        case 12: Console.WriteLine("该月份有31天"); break;
                        case 2: Console.WriteLine("改月份有29天"); break;
                        case 4:
                        case 6:
                        case 9:
                        case 11: Console.WriteLine("改月份有30天"); break;
                        default:
                            {
                                Console.WriteLine("输入月份错误"); break;
                            }
                    }
                }
            }
           
            Console.ReadKey();
        }
    }
}
