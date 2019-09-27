using _48简单工程设计模式.接口;
using System;
using System.Collections.Generic;
using System.Text;

namespace _48简单工程设计模式.工厂类
{
    /// <summary>
    /// 抽象工厂类
    /// </summary>
    public interface IIdentityProviderFactory
    {
        IIdentityProvider Create();
    }
}
