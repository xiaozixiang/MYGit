using _48简单工程设计模式.接口;
using System;
using System.Collections.Generic;
using System.Text;

namespace _48简单工程设计模式.具体实现类
{
    /// <summary>
    /// 微信第三方登录验证具体实习类
    /// </summary>
    class WechatIdentityProvider : IIdentityProvider
    {
        private static readonly string APPID = "你申请的运用ID";
        private static readonly string APPKEY = "你的私钥";

        public WechatIdentityProvider()
        {
            //微信验证具体实现逻辑
            Console.WriteLine("微信验证具体实现逻辑");
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
            //获取用户验证信息
        }
    }
}
