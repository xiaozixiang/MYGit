using System;
using System.Collections.Generic;
using System.Text;
using _48简单工程设计模式.具体实现类;
using _48简单工程设计模式.接口;

namespace _48简单工程设计模式.工厂类
{
    /// <summary>
    /// 支付宝登录验证工厂类
    /// </summary>
    public class AlipayIdentityProviderFactory : IIdentityProviderFactory
    {
        public IIdentityProvider Create()
        {
            return new AliPayIdentityProvider();
        }
    }
}
