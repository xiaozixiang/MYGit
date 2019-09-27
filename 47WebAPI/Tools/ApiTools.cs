using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Web;

namespace _47WebAPI.Tools
{
   public  class ApiTools
    {
        public enum ResponseCode
        {
            Success = 0,
            Fail = 1,
        }
        private string msgModel = "{{\"code\":{0},\"errmsg\":\"{1}\",\"data\":{2}}}";

        public HttpResponseMessage MsgFormat(ResponseCode code, string errmsg, string data)
        {
            string r = @"^(\-|\+)?\d+(\.\d+)?$";
            string json = string.Empty;
            if (Regex.IsMatch(data, r) || data.ToLower() == "true" || data.ToLower() == "false" || data == "[]" || data.Contains('{'))
            {
                json = string.Format(msgModel, (int)code, errmsg, data);
            }
            else
            {
                if (data.Contains('"'))
                {
                    json = string.Format(msgModel, (int)code, errmsg, data);
                }
                else
                {
                    json = string.Format(msgModel, (int)code, errmsg, "\"" + data + "\"");
                }
            }
            return new HttpResponseMessage { Content = new StringContent(json, System.Text.Encoding.UTF8, "application/json") };
        }
    }
}