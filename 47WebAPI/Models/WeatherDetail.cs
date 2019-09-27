using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _47WebAPI.Models
{
    public class WeatherDetail
    {
        /// <summary>
        /// 省份
        /// </summary>
        public string Province { get; set; }

        /// <summary>
        /// 城市名称
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// 城市代码
        /// </summary>
        public int CityCode { get; set; }

        /// <summary>
        /// 图片名称
        /// </summary>
        public string PictureName { get; set; }

        /// <summary>
        /// 最后更新时间
        /// </summary>
        public DateTime LastUpdateTime{ get; set; }

        /// <summary>
        /// 气温
        /// </summary>
        public string Temperature { get; set; }

        /// <summary>
        /// 天气概况
        /// </summary>
        public string Survey { get; set; }

        /// <summary>
        /// 风向和风力
        /// </summary>
        public string WindForce { get; set; }

        /// <summary>
        /// 天气趋势开始图片名称
        /// </summary>
        public string BeginPicture { get; set; }

        /// <summary>
        /// 天气趋势结束图片名称
        /// </summary>
        public string EndPicture { get; set; }

        /// <summary>
        /// 现在的天气实况
        /// </summary>
        public string CurrentWeather { get; set; }

        /// <summary>
        /// 天气和生活指数
        /// </summary>
        public string WheatherLift { get; set; }

        /// <summary>
        /// 第二天的 气温
        /// </summary>
        public string NextDayTemperature { get; set; }

        /// <summary>
        /// 第二天的 天气概况
        /// </summary>
        public string NextDaySurvey { get; set; }

        /// <summary>
        ///第二天的 风向和风力
        /// </summary>
        public string NextDayWindForce { get; set; }

        /// <summary>
        /// 第二天的 天气趋势开始图片名称
        /// </summary>
        public string NextDayBeginPicture { get; set; }

        /// <summary>
        /// 第二天的 天气趋势结束图片名称
        /// </summary>
        public string NextDayEndPicture { get; set; }

        /// <summary>
        /// 第三天的 气温
        /// </summary>
        public string ThirdTemperature{ get; set; }

        /// <summary>
        /// 第三天的 天气概况
        /// </summary>
        public string ThirdSurvey { get; set; }

        /// <summary>
        /// 第三天的 风向和风力
        /// </summary>
        public string ThirdWindForce { get; set; }

        /// <summary>
        /// 第三天的 天气趋势开始图片名称
        /// </summary>
        public string ThirdBeginPicture { get; set; }

        /// <summary>
        /// 第三天的 天气趋势结束图片名称
        /// </summary>
        public string ThirdDayEndPicture { get; set; }

        /// <summary>
        /// 城市或地区的介绍
        /// </summary>
        public string ProvinceAdnCityIntroduce { get; set; }
    }
}