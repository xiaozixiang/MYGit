using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05demo
{
    class Program
    {
        static void Main(string[] args)
        {

            //输入班级数，然后依次输入学员成绩，计算班级学员的平均成绩和总成绩
                Console.WriteLine("请输入班级人数");
                String strsum = Console.ReadLine();
                int sum = 0;
                int totalscore = 0;
                try {
                    sum = Convert.ToInt32(strsum);
                }catch {
                    Console.WriteLine("输入格式错误");
                }
                for (int i = 0; i <sum; i++) {
                    Console.WriteLine("请输入学员成绩");
                    int total = Convert.ToInt32(Console.ReadLine());
                    totalscore += total;
                }
                double avg= totalscore / (sum*1.0);
                Console.WriteLine("总成绩是" + totalscore);
                Console.WriteLine("平均成绩是" + avg);
                Console.ReadKey();

        }
    }
}
