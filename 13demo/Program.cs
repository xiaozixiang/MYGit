using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13demo
{
    class Program
    {
        static void Main(string[] args)
        {

            String str = @"C:\Windows\Drivers\index.html";

            //获取指定文件的根目录信息
            Console.WriteLine(Path.GetPathRoot(str));
            //返回指定文件的文件名不包括扩展名
            Console.WriteLine(Path.GetFileNameWithoutExtension(str));
            //返回指定文件的扩展名
            Console.WriteLine(Path.GetExtension(str));
            //返回指定文件的绝对路径
            Console.WriteLine(Path.GetFullPath(str));
           //返回指定文件的目录信息
            Console.WriteLine(Path.GetDirectoryName(str));
            //返回指定文件的文件名和扩展名
            Console.WriteLine(Path.GetFileName(str));
            Console.WriteLine("================================");

            ////创建一个文件
            //File.Create(@"C:\Users\Administrator\Desktop\new.txt");
            ////删除指定的文件
            //File.Delete(@"C:\Users\Administrator\Desktop\new.txt");
            ////复制指定的文件  到一个新的文件
            //File.Copy(@"C:\Users\Administrator\Desktop\2018届毕业生安排表.doc", @"C:\Users\Administrator\Desktop\new.doc");
            ////删除指定的文件夹
            //File.Delete(@"C:\Users\Administrator\Desktop\new.doc");
            ////创建UTF-8编码的文件
            //File.CreateText(@"C:\Users\Administrator\Desktop\xiao.txt");
            //Console.ReadKey();

           //byte[] buffer= File.ReadAllBytes(@"C:\Users\Administrator\Desktop\2018届毕业生安排表.doc");
           //String s=Encoding.Default.GetString(buffer);
           //Console.WriteLine(s);
           //Console.ReadKey();

            String str1 = "今天天气好风光处处好晴朗";
            byte[] buffer=Encoding.Default.GetBytes(str1);
            File.WriteAllBytes(@"C:\Users\Administrator\Desktop\new.txt", buffer);
            Console.ReadKey();
        }
    }
}
