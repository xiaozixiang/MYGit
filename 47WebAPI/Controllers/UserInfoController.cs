using _47WebAPI.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using static _47WebAPI.Tools.ApiTools;

namespace _47WebAPI.Controllers
{
    public class UserInfoController : ApiController
    {
        private ApiTools tool = new ApiTools();

        //// GET api/<controller>
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET api/<controller>/5
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }

       
        [HttpPost]
        public HttpResponseMessage CheckUserName(string _userName)
        {
            int num= UserInfoGetCount(_userName);//查询是否存在该用户
            if (num > 0)
            {
                return tool.MsgFormat(ResponseCode.Fail, "不可注册/用户已注册", "");
            }
            else
            {
                return tool.MsgFormat(ResponseCode.Success, "可注册", "0 " + _userName);
            }
        }

        //检查用户名是否已注册
        private int UserInfoGetCount(string userName)
        {
            return userName == "admin" ? 1 : 0;
        }
    }
}