using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15demo
{
    class Program
    {
        static void Main(string[] args)
        {

            MobleStore ms = new U();
            
            Computer cm = new Computer();
            cm.Ms = ms;
            cm.CpuRead(ms);
            cm.CpuWrite(ms);
            Console.ReadKey();
        }

    }

    public abstract class MobleStore {

        public abstract void Read();
        public abstract void Write();
    }

    public class MobleDisk : MobleStore {

        public override void Write()
        {
            Console.WriteLine("移动硬盘在写数据");
        }

        public override void Read()
        {
            Console.WriteLine("移动硬盘在读数据");
        }

    }
    public class Mp3 : MobleStore {

        public override void Read()
        {
            Console.WriteLine("Mp3在读数据");
        }

        public override void Write()
        {
            Console.WriteLine("Mp3在写数据");
        }
    }
    public class U : MobleStore {

        public override void Read()
        {
            Console.WriteLine("U盘在读数据");
        }

        public override void Write()
        {
            Console.WriteLine("U盘在写数据");
        }
    }
    public  class Computer {
        MobleStore ms;

        public MobleStore Ms
        {
            get { return ms; }
            set { ms = value; }
        }


        public  void CpuRead(MobleStore ms) {
            ms.Read();
        }

        public  void CpuWrite(MobleStore ms) {
            ms.Write();
        }
    }
}
