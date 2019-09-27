using _48简单工程设计模式.接口;
using System;
using System.Collections.Generic;
using System.Text;

namespace _48简单工程设计模式.具体实现类
{
    /// <summary>
    /// 支付宝第三方登录验证具体实现类
    /// </summary>
    class AliPayIdentityProvider : IIdentityProvider
    {
        private static readonly string APPID = "你申请的运用ID";
        private static readonly string APPKEY = "你的私钥";
        public AliPayIdentityProvider()
        {
            // 登录支付宝 验证的具体实现代码
            Console.WriteLine("登录支付宝 验证的具体实现代码");
            
        }
        public void AuthorizationCode()
        {
          
            //获取AuthorizationCode
        }

        public void getToken()
        {
            // 获取Token
        }

        public void GetUserInfo()
        {
            //获取用户信息
        }
    }
}
