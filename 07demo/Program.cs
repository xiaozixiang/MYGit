using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07demo
{
    class Program
    {
        static void Main(string[] args)
        {

            //2006年培养学员80000人，每年增长25%，请问按此增长速度，到哪一年学员数量将达到20万人？

            int  year = 2006;
            double people=80000;
            while (people < 200000) {

                people *= 1.25;
                year++;
            }
            Console.WriteLine("到{0}年的时候学员数量将达到20万人", year);
            Console.ReadKey();

            Console.WriteLine("请输入你想要买的电脑的平牌");
            String brand = Console.ReadLine();
           
           NoteBook nb=   getNotebook(brand);
           nb.sayhello();
           Console.ReadKey();
        }

        public static NoteBook getNotebook(String brand) {
            NoteBook nb = null;
            switch (brand) {
                case "acer": nb = new acer(); break;
                case "lenovo": nb = new Lenovo(); break;
                case "IBM": nb = new IBM(); break;
            }
            return nb;
        }
    }

    public abstract class NoteBook {

        public abstract void sayhello();
    }

    public class acer : NoteBook {

        public override void sayhello()
        {
            Console.WriteLine("我是弘基电脑");
        }
    }
    public class Lenovo : NoteBook {

        public override void sayhello()
        {
            Console.WriteLine("我是联想电脑");
        }
    }
    public class IBM : NoteBook {
        public override void sayhello()
        {
            Console.WriteLine("我是IBM电脑");
        }
    }
}
