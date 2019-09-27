using _48简单工程设计模式.接口;
using System;
using System.Collections.Generic;
using System.Text;

namespace _48简单工程设计模式.具体实现类
{
    /// <summary>
    ///  微博第三方登录验证具体实现类
    /// </summary>
    class WieBoIndentityProvider : IIdentityProvider
    {
        public WieBoIndentityProvider()
        {
            //微博登录验证的具体实习代码
            Console.WriteLine("微博登录验证的具体实习代码");
        }
        public void AuthorizationCode()
        {
            //获取Authorization Code
        }

        public void getToken()
        {
            // 获取Token
        }

        public void GetUserInfo()
        {
            // 获取用户登录验证的信息
        }
    }
}
