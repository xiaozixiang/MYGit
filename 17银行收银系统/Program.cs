using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17银行收银系统
{
    class Program
    {
        static void Main(string[] args)
        {
            SupperMaket sm = new SupperMaket();
            sm.ShowProduct();
            sm.AskBuying();
            Console.ReadKey();
        }
    }
}
