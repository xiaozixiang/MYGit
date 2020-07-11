using LogCommer;
using System;
using System.IO;
using System.Net;

namespace _08demo
{
    class Program
    {
        static void Main(string[] args)
        {

            //九九乘法表
            for (int i = 1; i <=9; i++)
            {
                for (int j = 1; j <=i; j++)
			    {
                    Console.Write("{0}*{1}={2}\t", i, j, i * j);
			    }
                Console.WriteLine();
            }
            Console.ReadKey();

            int number = 1;
           bool b= int.TryParse("123abc", out number);
           Console.WriteLine(b);
           Console.WriteLine(number);

            //其中的asynThreadCount参数默认是1，代表后台独立线程独立处理日志;我这边设置为0，代表同步处理日志。
            string AddressIP = string.Empty;
            foreach (IPAddress _IPAddress in Dns.GetHostEntry(Dns.GetHostName()).AddressList)
            {
                if (_IPAddress.AddressFamily.ToString() == "InterNetwork")
                {
                    AddressIP = _IPAddress.ToString();
                }
            }
            LogHelper logHelper = new LogHelper("demo8.exe", Path.Combine(Environment.CurrentDirectory, "Logs"), null, 0, "Log");
            logHelper.Log("错误消息记录测试","1", EnLogLevel.Error, "xiaozixiang", AddressIP);
           Console.ReadKey();
           
        }
    }
}
