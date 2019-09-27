using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Xml;

namespace _47WebAPI.Tools
{
    public class WebServiceHelper
    {
        public static string Get(string strURL)
        {
            //创建一个HTTP请求
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(strURL);
            request.Method = "GET";

            request.ContentType = "application/json;charset=UTF-8";// "text/xml;charset=utf-8";
            request.UserAgent = "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.1; SV1; Maxthon; .NET CLR 1.1.4322)";
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();//获取http请求的响应对象 

            Stream s = response.GetResponseStream();
          
            StreamReader sr = new StreamReader(s, Encoding.GetEncoding("utf-8"));
            string strValue = sr.ReadToEnd();
            sr.Close();
            //转化为XML，自己进行处理 
            //XmlTextReader Reader = new XmlTextReader(s);
            //Reader.MoveToContent();
            //string strValue = Reader.ReadInnerXml();
            //Reader.Close();
            return strValue;
        }
        public static string Post(string strURL, string param)
        {
            //创建一个HTTP请求
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(strURL);
            //Post请求方式    
            request.Method = "POST";
            request.Timeout = 300000;
            //获取客户端浏览器的原始用户代理信息。
            request.UserAgent = "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.1; SV1; Maxthon; .NET CLR 1.1.4322)";
            //request.Headers.Add("api-version", "2.0"); 
            request.ContentType = "application/x-www-form-urlencoded";//内容类型  
            byte[] postData = System.Text.Encoding.UTF8.GetBytes(param); //将参数编码后的字符串转化为字节
            request.ContentLength = postData.Length; //设置请求的ContentLength 
            Stream writer = request.GetRequestStream();//发送请求，获得请求流 
            writer.Write(postData, 0, postData.Length); //将请求参数写入流 
            writer.Close();//关闭请求流

            //获得响应流
            HttpWebResponse response;
            try
            {

                response = (HttpWebResponse)request.GetResponse();
            }
            catch (WebException ex)
            {
                return ex.Message;
            }
            Stream s = response.GetResponseStream();
            StreamReader sr = new StreamReader(s, Encoding.GetEncoding("utf-8"));
            string result = sr.ReadToEnd();
            sr.Close();
            s.Close();
            return result;
        }
    }
}