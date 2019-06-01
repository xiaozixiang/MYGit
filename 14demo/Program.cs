using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14demo
{
    class Program
    {
        static void Main(string[] args)
        {

            //FileStream fread = new FileStream(@"C:\Users\Administrator\Desktop\new.txt", FileMode.OpenOrCreate, FileAccess.Read);
            //byte[] buffer = new byte[1024 * 1024 * 5];
            
            //String str = "";
            //while (true) {

            //   int r = fread.Read(buffer, 0, buffer.Length);
            //    if (r == 0) {
            //        break;
            //    }
            //    str = Encoding.Default.GetString(buffer, 0, r);
            //}
              
            
            //fread.Close();
            //fread.Dispose();
            //Console.WriteLine(str);
            //Console.ReadKey();

            //using (FileStream fwrite = new FileStream(@"C:\Users\Administrator\Desktop\new.txt", FileMode.OpenOrCreate, FileAccess.Write))
            //{
            //    String str1="肖自翔你好呀！！！";
            //    byte[] buffer1=Encoding.Default.GetBytes(str1);
            //    fwrite.Write(buffer1, 0, buffer1.Length);
            //    Console.WriteLine("写入成功!!");
            //    Console.ReadKey();
            //}

            String source = @"E:\视屏\SpringMVC\01_spring mvc介绍.mp4";
            String target = @"C:\Users\Administrator\Desktop\01_spring mvc介绍.mp4";
            copy(source, target);
            Console.WriteLine("复制成功");
            Console.ReadKey();
        }


        public static void copy(String source, String target) {
            using (FileStream fread = new FileStream(source, FileMode.Open, FileAccess.Read))
            {
                using (FileStream fwrite = new FileStream(target, FileMode.OpenOrCreate, FileAccess.Write))
                { 

                        byte[] buffer=new byte[1024*1024*5];
                        while (true) {
                            int r = fread.Read(buffer, 0, buffer.Length);
                            if (r == 0) {
                                break;
                            }
                            fwrite.Write(buffer, 0, r);
                        }
                }
            }
        
        }
    }
}
