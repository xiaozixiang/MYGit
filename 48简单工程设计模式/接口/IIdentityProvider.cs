using System;
using System.Collections.Generic;
using System.Text;

namespace _48简单工程设计模式.接口
{
    /// <summary>
    /// 身份验证公共接口
    /// </summary>
    public interface IIdentityProvider
    {
        /// <summary>
        /// 获取Authorization Code
        /// </summary>

        void AuthorizationCode();
        /// <summary>
        /// 获取Token
        /// </summary>
        void getToken();

        /// <summary>
        /// 获取用户登录信息
        /// </summary>
        void GetUserInfo();
    }
}
