using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _10demo
{

    public struct Mycolor {
        public int _red;
        public int _blue;
        public int _green;

    }
    class Program
    {
        static void Main(string[] args)
        {
            Mycolor mc;
            mc._red = 255;
            mc._blue = 0;
            mc._green = 0;
            Console.WriteLine(mc._red);
            int[] nums = new int[10];
            int max = nums[0];
            int sum = nums[0];
            for (int i = 0; i <nums.Length; i++) { 
                nums[i]=i+1;
            }
                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[j] > max)
                    {
                        max = nums[j];
                    }
                    sum += nums[j];
                }
            Console.WriteLine(max);
            Console.WriteLine(sum);

                Console.ReadKey();

                //Directory.CreateDirectory(@"C:\a");
                //Console.WriteLine("创建成功");

                Directory.Delete(@"C:\a", true);
                Console.ReadKey();

        }

    }
}
