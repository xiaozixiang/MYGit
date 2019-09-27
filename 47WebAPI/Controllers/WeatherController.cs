using _47WebAPI.Models;
using _47WebAPI.Tools;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;

namespace _47WebAPI.Controllers
{
    [RoutePrefix("api/Weather")]
    public class WeatherController : ApiController
    {
        private const string Url = @"http://www.webxml.com.cn/WebServices/WeatherWebService.asmx";
        WebReference.WeatherWebService webService = new WebReference.WeatherWebService();
       // WebReference1.MobileCodeWS  mobileService = new  WebReference1.MobileCodeWS();
        /// <summary>
        /// 获取城市代码
        /// </summary>
        /// <param name="ProvinceName">城市名称</param>
        /// <returns></returns>
        [Route("getSupportCity/{ProvinceName}")]
        [HttpGet()]
        public JsonResult<List<WeatherCode>> getSupportCity(string ProvinceName)
        {
            #region 方法一
            //string strUrl = Url+"?"+"byProvinceName=" + ProvinceName;

            //#region 方法一获取接口数据 通过WebClient 方法获取
            ////WebClient webClient = new WebClient();
            ////webClient.Encoding = System.Text.Encoding.UTF8;
            //////获取数据
            ////var result = webClient.DownloadString(strUrl);
            //#endregion



            //#region 方法二获取接口数据 通过HTTPWebRequest方法获得
            //string xmlString = WebServiceHelper.Get(strUrl);
            //#endregion
            //List<string> list = new List<string>();

            //// xmlString.Trim();
            //// WeatherCode weatherCode = XMLHelper.XmlDeserialize<WeatherCode>(xmlString); 
            #endregion

            List<WeatherCode> weatherCodes = new List<WeatherCode>();
            string[] strarry = webService.getSupportCity(ProvinceName);
            weatherCodes = ComonTool.GetWeatherCode(strarry);
            return Json<List<WeatherCode>>(weatherCodes);
        }
        /// <summary>
        /// 国内外省份和城市信息
        /// </summary>
        /// <returns></returns>
        [Route("getSupportDataSet")]
        [HttpGet()]
        public JsonResult<List<Zones>> getSupportDataSet()
        {
            List<Zones> zonesList = new List<Zones>();
            DataSet dataSet = webService.getSupportDataSet();
            DataTable tableZone = dataSet.Tables[0];
            DataTable tableArea = dataSet.Tables[1];
            for (int i = 0; i < tableZone.Rows.Count; i++)
            {
                DataRow dr = tableZone.Rows[i];
                Zones zones = new Zones();
                zones.ID = Convert.ToInt32(dr[0].ToString());
                zones.Zone = dr[1].ToString();
                zones.Areas = new List<Models.Areas>();
                DataRow[] drarry = tableArea.Select("ZoneID=" + dr[0]);
                foreach (var item in drarry)
                {
                    Models.Areas areas = new Models.Areas()
                    {
                        ID = Convert.ToInt32(item[0].ToString()),
                        ZoneID = Convert.ToInt32(item[1].ToString()),
                        Area = item[2].ToString(),
                        AreaCode = item[3].ToString()
                    };
                    zones.Areas.Add(areas);
                }
                zonesList.Add(zones);
            };
            return Json<List<Zones>>(zonesList);
        }

        /// <summary>
        /// 获取支持的洲、国内外省份和城市信息
        /// </summary>
        /// <returns></returns>
        [Route("getSupportProvince")]
        [HttpGet()]
        public JsonResult<dynamic> getSupportProvince()
        {
            string[] strarray = webService.getSupportProvince();

            return Json<dynamic>(strarray.ToArray());
        }
        /// <summary>
        /// 根据城市或地区名称查询获得未来三天内天气情况、现在的天气实况、天气和生活指数
        /// </summary>
        /// <returns></returns>
        [Route("getWeatherbyCityName/{theCityName}")]
        [HttpGet()]
        public JsonResult<WeatherDetail> getWeatherbyCityName(string theCityName)
        {
            string[] strarry = webService.getWeatherbyCityName(theCityName);
            WeatherDetail weatherDetail = new WeatherDetail()
            {
                Province = strarry[0].ToString(),
                City = strarry[1].ToString(),
                CityCode = Convert.ToInt32(strarry[2].ToString()),
                PictureName = strarry[3].ToString(),
                LastUpdateTime = Convert.ToDateTime(strarry[4]),
                Temperature = strarry[5].ToString(),
                Survey = strarry[6].ToString(),
                WindForce = strarry[7].ToString(),
                BeginPicture = strarry[8].ToString(),
                EndPicture = strarry[9].ToString(),
                CurrentWeather = strarry[10].ToString(),
                WheatherLift = strarry[11].ToString(),
                NextDayTemperature = strarry[12].ToString(),
                NextDaySurvey = strarry[13].ToString(),
                NextDayWindForce = strarry[14].ToString(),
                NextDayBeginPicture = strarry[15].ToString(),
                NextDayEndPicture = strarry[16].ToString(),
                ThirdTemperature = strarry[17].ToString(),
                ThirdSurvey= strarry[18].ToString(),
                ThirdWindForce= strarry[19].ToString(),
                ThirdBeginPicture= strarry[20].ToString(),
                ThirdDayEndPicture= strarry[21].ToString(),
                ProvinceAdnCityIntroduce = strarry[22].ToString(),
            };
            return Json<WeatherDetail>(weatherDetail);
        }
    }
}