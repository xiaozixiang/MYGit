using _48简单工程设计模式.接口;
using System;
using System.Collections.Generic;
using System.Text;

namespace _48简单工程设计模式.具体实现类
{
    /// <summary>
    /// QQ第三方登录验证具体实习类
    /// </summary>
    class QQIdentityProvider : IIdentityProvider
    {

        public QQIdentityProvider()
        {
            //QQ第三方登录验证具体逻辑代码
            Console.WriteLine("QQ第三方登录验证具体逻辑代码");
        }
        public void AuthorizationCode()
        {
            //获取 Authorization Code 
        }

        public void getToken()
        {
            //获取 登录Token 
        }

        public void GetUserInfo()
        {
           //获取用户验证信息
        }
    }
}
