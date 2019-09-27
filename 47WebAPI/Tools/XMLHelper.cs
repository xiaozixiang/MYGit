using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Xml;
using System.Xml.Serialization;

namespace _47WebAPI.Tools
{
    public class XMLHelper
    {
        /// <summary>
        /// 对象序列化成 XML的 String类型
        /// </summary>
        /// <typeparam name="T">类型</typeparam>
        /// <param name="obj">类型</param>
        /// <returns></returns>
        public static string XmlSerialize<T>(T obj)
        {
            string xmlString = string.Empty;
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
            using (MemoryStream ms = new MemoryStream())
            {
                xmlSerializer.Serialize(ms, obj);
                xmlString = Encoding.UTF8.GetString(ms.ToArray());
            }
            return xmlString;
        }
        /// <summary>
        /// XML的String类型文档 反序列化成对象
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="xmlString"></param>
        /// <returns></returns>
        public static T XmlDeserialize<T>(string xmlString)
        {
            T t = default(T);
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
            #region 方法一
            try
            {
                using (Stream xmlstream = new MemoryStream(Encoding.UTF8.GetBytes(xmlString)))
                {
                    using (XmlReader xmlReader = XmlReader.Create(xmlstream))
                    {
                        Object obj = xmlSerializer.Deserialize(xmlReader);
                        t = (T)obj;
                    }
                }
            }
            catch(Exception e)
            {
            }
            #endregion

            return t;
        }
    }
}