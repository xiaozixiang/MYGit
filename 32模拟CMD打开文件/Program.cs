using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32模拟CMD打开文件
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true) {
                try
                {
                    Console.WriteLine("请输入你要到的文件路径");
                    String paht = Console.ReadLine();//D:\
                    Console.WriteLine("请输入你要打开的文件夹");
                    String fileName = Console.ReadLine();//1.txt
                    FIleFather ff = GetFile(fileName, paht + fileName);
                    ff.FullPath = paht + fileName;
                    ff.OpenFile();
                }
                catch { }
            }
            
        }
        public static  FIleFather GetFile(String FileName,String fullpath) {
            FIleFather ff = null;
            String exetesion = Path.GetExtension(FileName);
            switch (exetesion)
            { 
                case ".txt":ff=new TxtFile(fullpath);break;
                case ".jpg":ff=new JpgFile(fullpath);break;
                case ".exe":ff=new ExeFile(fullpath);break;
            }
            return ff;
        }
    }
}
