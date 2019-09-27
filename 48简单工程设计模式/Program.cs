using _48简单工程设计模式.具体实现类;
using _48简单工程设计模式.工厂类;
using _48简单工程设计模式.接口;
using System;

namespace _48简单工程设计模式
{
    class Program
    {
        static void Main(string[] args)
        {
            //调用支付宝第三方工厂类
            IIdentityProviderFactory factory  = new AlipayIdentityProviderFactory();
             factory.Create();
            Console.ReadKey();
        }
    }
}
