using _47WebAPI.Models;
using _47WebAPI.Tools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;
using System.Windows.Forms;

namespace _47WebAPI.Controllers
{
    [RoutePrefix("api/Logistics")]
    public class LogisticsController : ApiController
    {
        /// <summary>
        /// 拿到物流信息
        /// </summary>
        /// <param name="type">快递公司代号:快递公司编码:申通="shentong" EMS="ems" 顺丰="shunfeng" 圆通="yuantong" 中通="zhongtong" 韵达="yunda" 天天="tiantian" 汇通="huitongkuaidi" 全峰="quanfengkuaidi" 德邦="debangwuliu" 宅急送="zhaijisong"</param>
        /// <param name="postid">快递单号</param>
        /// <returns></returns>
        [Route("GetLogisticsInfo")]
        [HttpGet()]
        public JsonResult<Logistics> GetLogisticsInfo(string type,string postid)  //JsonResult<dynamic>
        {
            string Url = string.Format(@"http://www.kuaidi100.com/query?type={0}&postid={1}", type, postid);
            string Result= WebServiceHelper.Get(Url);
            Logistics logistics =JsonConvert.DeserializeObject<Logistics>(Result);

            return Json<Logistics>(logistics);
        }
    }
}