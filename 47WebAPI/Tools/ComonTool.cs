using _47WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace _47WebAPI.Tools
{
    public class ComonTool
    {
        /// <summary>
        /// 拿的城市代码的一维数组，然后以-（-分割开
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static List<WeatherCode> GetWeatherCode(string[] array)
        {
            List<WeatherCode> weatherList = new List<WeatherCode>();
            foreach (var item in array)
            {
                WeatherCode weatherCode = new WeatherCode();
                weatherCode.WeatherName = item.Split('(')[0].Trim().ToString(); //Regex.Split(item, "（", RegexOptions.IgnoreCase)[0].Trim().ToString();
                weatherCode.WeahterCode = item.Split('(')[1].TrimEnd(')').Trim().ToString() ;
                weatherList.Add(weatherCode);
            }
            return weatherList;
        }

        /// <summary>
        /// 分离字符串  江西 吉安 236 截取 数字
        /// </summary>
        /// <param name="strarray"></param>
        /// <returns></returns>
        public static IList<int> GetNumberic(string[] strarray)
        {
            IList<int> numbericList = new List<int>();
            foreach (var item in strarray)
            {
                MatchCollection ms = Regex.Matches(item, @"\d+");
                foreach (Match m in ms)
                {
                    numbericList.Add(Convert.ToInt32(m.Value));
                }
            }
            return numbericList;
        }

        /// <summary>
        /// 分离字符串  江西 吉安 236 截取 中文
        /// </summary>
        /// <param name="strarray"></param>
        /// <returns></returns>
        public static IList<string> GetStrings(string[] strarray)
        {
            IList<string> strList = new List<string>();
            foreach (var item in strarray)
            {
                MatchCollection ms = Regex.Matches(item, @"\D+");
                foreach (Match m in ms)
                {
                    strList.Add(m.Value);
                }
            }
            return strList;
        }
    }
}