using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {

        public static  int b = 10;

        static void Main(string[] args)
        {
            //Console.WriteLine("this is my second project");
            //Console.ReadKey();
            //Console.WriteLine("请输入你的姓名：");
            //String str = Console.ReadLine();
            //Console.WriteLine("你输入的姓名是{0}", str);
            //Console.ReadKey();

            ////Console.WriteLine();
            //String str =" 你好 肖自翔 ";
            //System.IO.File.WriteAllText(@"C:\Users\Administrator\Desktop\111.txt",str);
            //Console.WriteLine("写入成功");

            //int n1 = 10;
            //int n2 = 3;
            //double result = n1 * 1.0 / n2;
            //#region
            //Console.WriteLine("{0:0.00}", result);
            //#endregion
            //Console.WriteLine(result);
            //Console.ReadKey();

            //String[] names = { "我", "是", "好人"};
            //String temp = "";

            //for (int i = 0; i < names.Length/2; i++)
            //{
            //    temp= names[i];
            //    names[i] = names[names.Length -i- 1];
            //    names[names.Length - i - 1] = temp;
            //}
            //for (int j = 0; j <names.Length; j++)
            //{
            //    Console.Write(names[j]);
            //}

            int[] nums = new int[] { 9,8,7,6,5,4,3,2,1,0};

            int max;
            int min;
            double sum;
            double avg;
            test(nums,out max,out min,out sum,out avg);
            Console.WriteLine(max);
            Console.WriteLine(min);
            Console.WriteLine(sum);
            Console.WriteLine(avg);
            Console.ReadKey();

            //升序
            Array.Sort(nums);

            //翻转
            //Array.Reverse(nums);
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length - 1 - i; j++)
                {
                    if (nums[j] > nums[j + 1])
                    {
                        int temp = nums[j];
                        nums[j] = nums[j + 1];
                        nums[j + 1] = temp;
                    }
                }
            }
            for (int k = 0; k < nums.Length; k++)
            {
                Console.Write(nums[k] + "\t");
            }
                Console.ReadKey();
           
        }
        public static void testc(){
            b += b;
        }

        public static void test(int[] nums, out int max, out int min, out double sum, out double avg) {
            max=nums[0];
            min=nums[0];
            sum=0;
            avg=0;
            
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > max) {
                    max = nums[i];
                }
                if (nums[i] < min) {
                    min = nums[i];
                }
                sum += nums[i];
            }
            avg = sum*1.0 / nums.Length*1.0;
        }
    }
}
