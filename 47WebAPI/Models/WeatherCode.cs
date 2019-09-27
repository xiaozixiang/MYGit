using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace _47WebAPI.Models
{
    public class WeatherCode
    {
        /// <summary>
        /// 城市名称
        /// </summary>
        public string WeatherName { get; set; }

        /// <summary>
        /// 城市代码
        /// </summary>
        public string WeahterCode { get; set; }
    }
}