using System;
using System.Collections.Generic;
using System.Text;

namespace LogCommer
{
    [Serializable]
   public  class LogModal
    {
        /// <summary>
        /// 日志信息
        /// </summary>
        public string Message { get; set; }
        /// <summary>
        /// 日志记录者，一般是源程式名称，比如前台程式1、前台程式2、后台程式1...
        /// </summary>
        public string Recorder { get; set; }
        /// <summary>
        /// 日志级别
        /// (varchar(10) 一定是英文的字段)
        /// </summary>
        public string LogLevel { get; set; }
        /// <summary>
        /// 日志分类。由调用方自定义
        /// </summary>
        public string LogCategory { get; set; }
        /// <summary>
        /// 日志写入的时间
        /// </summary>
        public DateTime CreateTime { get; set; }
        public int Thread { get; set; }
        /// <summary>
        /// 如果是某个用户操作的日志，则建议记录:用户Id_Name
        /// </summary>
        public string LogUser { get; set; }
        public string Ip { get; set; }
    }

    /// <summary>
    /// 自定义日志等级
    /// </summary>
    public enum EnLogLevel
    {
        Info,
        Warning,
        Error,
        Fata
    }
}
