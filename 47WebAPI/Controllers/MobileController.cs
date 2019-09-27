using _47WebAPI.Models;
using _47WebAPI.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;

namespace _47WebAPI.Controllers
{
    [RoutePrefix("api/Moblie")]
    public class MobileController : ApiController
    {
        WebReference1.MobileCodeWS mobileService = new WebReference1.MobileCodeWS();

        /// <summary>
        /// 获得国内手机号码归属地数据库信息
        /// </summary>
        /// <returns>一维数组（省份 城市 记录数量）</returns>
        [Route("getDatabaseInfo")]
        [HttpPost()]
        public JsonResult<List<Mobile>> getDatabaseInfo()
        {
            List<Mobile> mobiles = new List<Mobile>();
            string[] strarray = mobileService.getDatabaseInfo();
            List<int> RecordNumber =(List<int>)ComonTool.GetNumberic(strarray);
            List<string> ProvinceAdnCity = (List<string>)ComonTool.GetStrings(strarray);
            for (int i = 0; i < RecordNumber.Count; i++)
            {
                Mobile mobile = new Mobile();
                mobile.Record = RecordNumber[i];
                mobile.ProvinceAndCity = ProvinceAdnCity[i];
                mobiles.Add(mobile);
            }
            return Json<List<Mobile>>(mobiles);
        }
        /// <summary>
        /// 获得国内手机号码归属地省份、地区和手机卡类型信息
        /// </summary>
        /// <param name="mobileCode">字符串（手机号码，最少前7位数字)</param>
        /// <param name="userID">字符串（商业用户ID） 免费用户为空字符串</param>
        /// <returns>字符串（手机号码：省份 城市 手机卡类型）</returns>
        [Route("getMobileCodeInfo")]
        [HttpGet()]
        public JsonResult<string> getMobileCodeInfo(string mobileCode,string userID)
        {
            string str= mobileService.getMobileCodeInfo(mobileCode, userID);
            return Json<string>(str);
        }

    }
}