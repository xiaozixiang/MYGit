using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06demo
{
    class Program
    {
        static void Main(string[] args)
        {

            //老师问学生这道题你会了吗？如果学生回答会（yes）了，则可以放学，如果学生不会做（no），
            //则老师在将一遍,在问学生会做了？知道学生会了才可以放学，直到学生会或老师讲了10遍都要放学。
            Console.WriteLine("这道题你会了吗？（Yes Or No）");
            String answer = Console.ReadLine();
            if (answer.Trim().Equals("Yes")) {
                Console.WriteLine("可以放学了");
            }
            if (answer.Trim().Equals("No")) {
                Console.WriteLine("老师在讲一遍，在问会了吗（Yes Or No）？");
                String answer1 = Console.ReadLine();
                int i=0;
                while (answer1.Trim().Equals("No") && i <= 10) {

                    Console.WriteLine("老师在讲一遍，在问会了吗（Yes Or No）？");
                    String answer2 = Console.ReadLine();
                    if (answer2.Trim().Equals("Yes")) {
                        Console.WriteLine("放学");
                    }
                    i++;
                }
                
            
            }
            Console.ReadKey();
        }
    }
}
