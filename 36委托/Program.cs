using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36委托
{
    class Program
    {
        public delegate void  delsayhi(String name);

        public delegate int Compare(object o1, object o2);

        static void Main(string[] args)
        {
            object[] o={ 1, 2, 3, 4, 5 };
            object result = getMax(o, delegate(object o1, object o2)
            {
                int n1 = (int)o1;
                int n2 = (int)o2;
                return n1 - n2;
            });
            Console.WriteLine(result);

            Test("张三", sayhienglish);
            Console.ReadKey();
        }

        public static void Test(String name, delsayhi del)
        {
            del(name);
        }
        public static void sayhichinese(String name) {
            Console.WriteLine("吃了吗？"+name);
        }
        public static void sayhienglish(String name) {
            Console.WriteLine("Nice meet you"+name);
        }



        public static object getMax(object[] o,Compare del) {
            object max = o[0];
            for (int i = 0; i < o.Length; i++)
            {
                if(del(max,o[i])<0){
                    max=o[i];
                }
            }
            return max;
        }
    }
}
