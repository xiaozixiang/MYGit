using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using _47WebAPI.ConvertHelper;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace _47WebAPI.Models
{
    [Serializable]
    public class Logistics
    {
        /// <summary>
        /// 物流消息
        /// </summary>
        [JsonProperty("message")]
        public string Message { get; set; }
        /// <summary>
        /// 物流单号
        /// </summary>
        [JsonProperty("nu")]
        public string Nu { get; set; }

        /// <summary>
        /// 是否签收
        /// </summary>
        [JsonProperty("ischeck")]
       // [JsonConverter(typeof(BoolConverter))]
        public string IsCheck { get; set; }

        /// <summary>
        /// 物流公司名称网站
        /// </summary>
        [JsonProperty("com")]
        public string Com { get; set; }
        /// <summary>
        /// 状态 200
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("condition")]
        public string Condition { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("state")]
        public int State { get; set; }

        [JsonProperty("data")]
        public List<LogisticsData> Data { get; set; }
    }

    public class LogisticsData
    {
        /// <summary>
        /// 开始配送时间
        /// </summary>
        [JsonProperty("time"), JsonConverter(typeof(DataTimeConvert))]
        public DateTime Time { get; set; }

        /// <summary>
        /// 类容
        /// </summary>
        [JsonProperty("context")]
        public string Context { get; set; }

        /// <summary>
        /// 配送结束时间
        /// </summary>
        [JsonProperty("ftime"), JsonConverter(typeof(DataTimeConvert))]
        public DateTime FTime { get; set; }

        /// <summary>
        /// 到达位置
        /// </summary>
        [JsonProperty("location",NullValueHandling=NullValueHandling.Ignore)]
        public string Loation { get; set; }
    }

}