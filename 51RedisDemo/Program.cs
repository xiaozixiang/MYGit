using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack.Redis;
using ServiceStack.Text;

namespace _51RedisDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            RedisClient redisClient = new RedisClient("127.0.0.1", 6379);
            redisClient.FlushAll();

            redisClient.Set<string>("key", "肖自翔");
            string value= redisClient.Get<string>("key");
            Console.WriteLine(value);
            Console.ReadKey();



        }
    }
}
