using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace _28Dialog.ApiHelper
{
    public class ApiHelper
    {
        /// <summary>
        /// 调用api返回json
        /// </summary>
        /// <param name="url">api地址</param>
        /// <param name="jsonstr">接收参数</param>
        /// <param name="type">类型（post，get）</param>
        /// <returns></returns>
        public static string httpApi(string url, string jsonstr, string type)
        {
            Encoding encoding = Encoding.UTF8;
            HttpWebRequest httpWebRequest =(HttpWebRequest) WebRequest.Create(url);
            httpWebRequest.Accept = "text/html,application/xhtml+xml,*/*";
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = type.ToUpper().ToString();//get或者post
            byte[] buffer = encoding.GetBytes(jsonstr);
            httpWebRequest.ContentLength = buffer.Length;
            httpWebRequest.GetRequestStream().Write(buffer, 0, buffer.Length);
            HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (StreamReader reader=new StreamReader(httpWebResponse.GetResponseStream(),Encoding.UTF8))
            {
                return reader.ReadToEnd();
            }

        }
    }
}
