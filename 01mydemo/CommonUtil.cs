using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace _01mydemo
{
    public class CommonUtil
    {
        /// <summary>
        /// 字符串转换
        /// </summary>
        /// <param name="str">原字符串</param>
        /// <param name="byteNum">字节</param>
        /// <returns></returns>
        public static string formatStr(string str, int byteNum)
        {
            // 最后一个字节为空格
            int num = byteNum - 1;

            string newStr = string.Empty;

            // 获取字符串字节长度
            int len = System.Text.Encoding.Default.GetByteCount(str);
            // 将字符串转换为字节数组
            byte[] strBytes = System.Text.Encoding.Default.GetBytes(str);
            // 定义一个新的字节数据 长度为num
            byte[] newBytes = new byte[num];
            // 如果字符串字节长度 > 定义的字节长度
            if (len >= byteNum)
            {
                // 截取字符串字节
                Buffer.BlockCopy(strBytes, 0, newBytes, 0, num);
                // 将字节数组转换为字符串
                newStr = System.Text.Encoding.Default.GetString(newBytes);
                // 若最后一位为？ 这转换为空格
                if (newStr.EndsWith("?"))
                {
                    newStr = newStr.Substring(0, newStr.Length - 1) + " ";
                }
                newStr += " ";
            }
            else
            {
                // 若字节长度不足 则补空格
                for (int i = 0; i < byteNum - len; i++)
                {
                    str += " ";
                }
                newStr = str;
            }

            // 返回最新的字符串
            return newStr;
        }

        public static string formatSn(string sn)
        {
            string newSn = string.Empty;
            int i = sn.IndexOf("_");
            if (i > 0)
            {
                newSn = sn.Substring(0, sn.IndexOf("_")).PadLeft(13, ' ');
            }
            else
            {
                newSn = sn.PadLeft(13, ' ');
            }

            return newSn;
        }

        /// <summary>
        /// 加 decimal
        /// </summary>
        /// <returns></returns>
        public static string add(string str1, string str2)
        {
            decimal num1;
            decimal num2;
            string str = string.Empty;
            bool a = decimal.TryParse(str1, out num1);
            bool b = decimal.TryParse(str2, out num2);
            if (a && b)
            {
                str = (num1 + num2).ToString("#0.00");
            }
            else
            {
                str = "格式错误";
            }
            return str;
        }

        /// <summary>
        /// 加 int
        /// </summary>
        /// <param name="str1"></param>
        /// <param name="str2"></param>
        /// <returns></returns>
        public static string addInt(string str1, string str2)
        {
            int num1;
            int num2;
            string str = string.Empty;
            bool a = int.TryParse(str1, out num1);
            bool b = int.TryParse(str2, out num2);
            if (a && b)
            {
                str = (num1 + num2).ToString();
            }
            else
            {
                str = "格式错误";
            }
            return str;
        }

        /// <summary>
        /// 减 decimal
        /// </summary>
        /// <returns></returns>
        public static string reduce(string str1, string str2)
        {
            decimal num1;
            decimal num2;
            string str = string.Empty;
            bool a = decimal.TryParse(str1, out num1);
            bool b = decimal.TryParse(str2, out num2);
            if (a && b)
            {
                str = (num1 - num2).ToString("#0.00");
            }
            else
            {
                str = "格式错误";
            }
            return str;
        }

        /// <summary>
        /// 减 int
        /// </summary>
        /// <param name="str1"></param>
        /// <param name="str2"></param>
        /// <returns></returns>
        public static string reduceInt(string str1, string str2)
        {
            int num1;
            int num2;
            string str = string.Empty;
            bool a = int.TryParse(str1, out num1);
            bool b = int.TryParse(str2, out num2);
            if (a && b)
            {
                str = (num1 - num2).ToString();
            }
            else
            {
                str = "格式错误";
            }
            return str;
        }

        /// <summary>
        /// 乘
        /// </summary>
        /// <returns></returns>
        public static string multiply(string str1, string str2)
        {
            decimal num1;
            decimal num2;
            string str = string.Empty;
            bool a = decimal.TryParse(str1, out num1);
            bool b = decimal.TryParse(str2, out num2);
            if (a && b)
            {
                str = (num1 * num2).ToString("#0.00");
            }
            else
            {
                str = "格式错误";
            }
            return str;
        }

        /// <summary>
        /// 除
        /// </summary>
        /// <returns></returns>
        public static string divide(string str1, string str2)
        {
            decimal num1;
            decimal num2;
            string str = string.Empty;
            bool a = decimal.TryParse(str1, out num1);
            bool b = decimal.TryParse(str2, out num2);
            if (a && b && num2 != 0)
            {
                str = (num1 / num2).ToString("#0.00");
            }
            else
            {
                str = "格式错误";
            }
            return str;
        }


        /// <summary>
        /// 判断 两个IP地址是否在同一网段中
        /// </summary>
        /// <param name="ipA"></param>
        /// <param name="ipB"></param>
        /// <returns></returns>
        public static bool IsSameLanNet(IPAddress ipA, IPAddress ipB)
        {
            long value = 256 * 256 * 256;
            if (ipA.Address % value == ipB.Address % value)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 手机号码隐私加密
        /// </summary>
        /// <param name="phone"></param>
        /// <returns></returns>
        public static string EncodingMemberPhone(string phone)
        {
            return phone.Substring(0, 3) + "****" + phone.Substring(7, phone.Length - 7);
        }

        public static T Clone<T>(T RealObject)
        {
            using (Stream objectStream = new MemoryStream())
            {
                //利用 System.Runtime.Serialization序列化与反序列化完成引用对象的复制 
                IFormatter formatter = new BinaryFormatter();
                formatter.Serialize(objectStream, RealObject);
                objectStream.Seek(0, SeekOrigin.Begin);
                return (T)formatter.Deserialize(objectStream);
            }
        }
    }
}
