using _48简单工程设计模式.具体实现类;
using _48简单工程设计模式.接口;
using System;
using System.Collections.Generic;
using System.Text;

namespace _48简单工程设计模式.工厂类
{
    /// <summary>
    /// 创建第三方登录验证的类实例的唯一入口
    /// </summary>
    public class IdentityProviderFactory
    {
        /// <summary>
        /// 创建第三方登录验证的唯一入口
        /// </summary>
        /// <param name="type"> type =1，Alipay登录验证 type=2 WeChat登录验证 type=3 QQ登录验证 type=4 微博登录验证</param>
        /// <returns></returns>
        public static IIdentityProvider Create(int type)
        {
            IIdentityProvider identityProvider = null;
            switch (type)
            {
                case 1: identityProvider = new AliPayIdentityProvider(); break;
                case 2: identityProvider = new WechatIdentityProvider(); break;
                case 3: identityProvider = new QQIdentityProvider(); break;
                case 4:identityProvider = new WieBoIndentityProvider();break;
            }
            return identityProvider;
        }
    }
}
