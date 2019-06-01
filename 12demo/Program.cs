using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12demo
{
    class Program
    {
        static void Main(string[] args)
        {

            Person[] p = new Person[10];
            Random r = new Random();
            for (int i = 0; i < p.Length; i++)
            {
                int rnumber = r.Next(1, 7);
                switch (rnumber) {
                    case 1: p[i] = new Student(); break;
                    case 2: p[i] = new Teacher(); break;
                    case 3: p[i] = new MeiNv(); break;
                    case 4: p[i] = new ShuiGuo(); break;
                    case 5: p[i] = new Person(); break;
                    case 6: p[i] = new YeShou(); break;
                }
            }
            for (int i = 0; i < p.Length; i++)
            {
                if (p[i] is Teacher) {
                    ((Teacher)p[i]).TeacherSayhi();
                }
                else if (p[i] is Student) {
                    ((Student)p[i]).StudentSayhi();
                }
                else if (p[i] is MeiNv) {
                    ((MeiNv)p[i]).MeiNvSayhi();
                }
                else if (p[i] is ShuiGuo) {
                    ((ShuiGuo)p[i]).ShuiGouSayhi();
                }
                else if (p[i] is YeShou) {
                    ((YeShou)p[i]).YeShouSayhi();
                }
                else if (p[i] is Person) {
                    p[i].PersonSayhi();
                }
            }
            Console.ReadKey();

        }
    }
}
