using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _18MD5
{
    class Program
    {
        static void Main(string[] args)
        {

            String s=getMd5("123");
            Console.WriteLine(s);
            Console.ReadKey();
        }

        public static String getMd5(String s) {
            byte[] buffer = Encoding.UTF8.GetBytes(s);
            MD5 md5 = MD5.Create();
           byte[] md5buffer= md5.ComputeHash(buffer);

           String str = "";
           for (int i = 0; i < md5buffer.Length; i++)
           {
               str += md5buffer[i].ToString("x2");
           }
           return str;
        }
    }
}
