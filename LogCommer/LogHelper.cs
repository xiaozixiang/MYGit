using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LogCommer
{
    /// <summary>
    /// 轻便快捷的日志操作类
    /// </summary>
    public class LogHelper
    {

        #region 属性
        /// <summary>
        /// 日志记录者
        /// </summary>
        public string Recorder { get; set; }

        /// <summary>
        /// txt日志的目录；如果不需要记录到txt则为null
        /// </summary>
        public string DirectoryForTxt { get; set; }

        /// <summary>
        /// 定义写入日志到数据库的委托；如果不需要记录到数据库则为null
        /// </summary>
        public Action<string, LogModal> DoInsertLogToDb { get; set; }

        /// <summary>
        /// 异步队列处理日志的线程数。0表示同步处理；1表示后台开一个线程异步处理日志任务队列..
        /// (建议异步处理的线程不需要太多，按日志量：1到2个线程就好。)
        /// </summary>
        protected int AsynThreadCount { get; set; }

        /// <summary>
        /// 需要写入日志的队列。
        /// (BlockingCollection多线程安全队列，可自动阻塞线程，默认是Queue结构)
        /// </summary>
        protected BlockingCollection<object> LogQueue = new BlockingCollection<object>();

        /// <summary>
        /// 默认insert Sql语句。调用方可修改InsertLogSql，比如如果是oracle数据库，则要把InsertLogSql语句中的@改为:
        /// (表名称可自定义。1 支持不同的表命名规则；2 支持实例化不同的表名称对象用于多表日志记录（比如分操作日志和系统后台日志等）)
        /// </summary>
        public string InsertLogSql = @" insert into {0}(Message,Recorder,LogLevel,LogCategory,CreateTime,Thread,LogUser,Ip) values (@Message,@Recorder,@LogLevel,@LogCategory,@CreateTime,@Thread,@LogUser,@Ip) ";
        #endregion

        #region 构造函数，配置日志
        /// <summary>
        /// 日志操作类，支持保存在数据库和本地txt
        /// </summary>
        /// <param name="recorder">日志记录者</param>
        /// <param name="directoryForTxt">winform程式参考：Path.Combine(Environment.CurrentDirectory, "Logs");
        /// web程式参考：System.Web.Hosting.HostingEnvironment.MapPath("~/Logs")</param>
        /// <param name="logToDbAction">日志写入数据库的委托。由调用方自动选择db日志写入方式，这样就可支持任何数据库类型写入日志</param>
        /// <param name="asynThreadCount">异步队列处理日志的线程数。0表示同步处理；大于0表示后台开asynThreadCount个线程异步处理日志任务队列.普通日志量推荐默认的1，这样系统可异步处理日志，如果日志出错也是会记录到本地tx；，如果日志量较多，可设置大一些。</param>
        /// <param name="logTableName">日志表名，表名称默认是TbLog，可以自定义，比如TbLog等。1. 为了不同的表命名规则；2. 为了支持多表日志记录（比如分操作日志和系统后台日志等）。</param>
        /// <param name="needStartLog">实例化日志对象时，是否记录一条start日志</param>
        public LogHelper(string recorder, string directoryForTxt = "", Action<string, LogModal> logToDbAction = null,
            int asynThreadCount = 1, string logTableName = "TbLog", bool needStartLog = true)
        {
            if (string.IsNullOrWhiteSpace(directoryForTxt) && logToDbAction == null)
            {
                throw new Exception("没有指定任何日志记录方式");
            }
            Recorder = recorder;
            DirectoryForTxt = directoryForTxt;
            //初始化时确保日志文件夹存在，之后写入txt不用一直判断
            if (!string.IsNullOrWhiteSpace(DirectoryForTxt) && !Directory.Exists(DirectoryForTxt))
            {
                Directory.CreateDirectory(DirectoryForTxt);
            }
            DoInsertLogToDb = logToDbAction;
            //指定日志表名
            InsertLogSql = string.Format(InsertLogSql, logTableName);
            AsynThreadCount = asynThreadCount;
            //如果AsynThreadCount>=0，则异步处理日志写入；如果如果AsynThreadCount<=0，则是同步写入日志。
            InitQueueConsume();
            if (needStartLog)
            {
                if (!string.IsNullOrWhiteSpace(DirectoryForTxt))
                {
                    LogToTxt(string.Format("init loghandle:{0}", Recorder), "start");
                }
                if (DoInsertLogToDb != null)
                {
                    LogToDb(string.Format("init loghandle:{0}", Recorder), "start");
                }
            }
        }
        /// <summary>
        /// 初始化异步处理队列
        /// </summary>
        protected virtual void InitQueueConsume()
        {
            for (int i = 0; i < AsynThreadCount; i++)//AsynThreadCount<=0的话，不会进入循环
            {
                Task.Factory.StartNew(() =>
                {
                    //GetConsumingEnumerable 如果队列中没有项，会自动阻塞等待Add。这个线程会一直在后台占用。
                    foreach (var item in LogQueue.GetConsumingEnumerable())
                    {
                        try
                        {
                            if (item is string)
                            {
                                DoInsertLogToTxt(item.ToString());
                            }
                            else
                            {
                                DoInsertLogToDb(InsertLogSql, (LogModal)item);
                            }
                        }
                        catch (Exception e)
                        {//如果在处理任务过程失败，需要捕获以继续处理下一个任务
                        }
                    }
                });
            }
        }
        #endregion



        #region Log、LogToDb、LogToTxt、LogToBoth
        /// <summary>
        /// 日志优先写入Db，当写入Db失败，才会写入txt。如果DoInsertLogToDb为null，则会自动选择写入txt。
        /// (这也是最常用的模式，太多日志是不建议写入txt)
        /// </summary>
        /// <param name="msg">日志信息</param>
        /// <param name="category">自定义类别</param>
        /// <param name="level">日志等级：Info,Warn,Error,Fatal,Debug</param>
        /// <param name="user"></param>
        /// <param name="ip"></param>
        public virtual void Log(string msg, string category = "", EnLogLevel level = EnLogLevel.Info, string user = "", string ip = "")
        {
            if (DoInsertLogToDb != null)
            {
                try
                {
                    LogToDb(msg, category, level, user, ip);
                }
                catch (Exception e)
                {
                    var exMsg = "-------------执行Log中的LogToDb时异常:" + LogHelper.GetExceptionDetailMsg(e);
                    if (!string.IsNullOrWhiteSpace(DirectoryForTxt))//如果写入数据库失败，则写入本地txt
                    {
                        LogToTxt(exMsg);
                        LogToTxt(msg, category, level, user, ip);
                    }
                    else
                    {
                        throw new Exception(exMsg);
                    }
                }
            }
            else if (!string.IsNullOrWhiteSpace(DirectoryForTxt))
            {
                LogToTxt(msg, category, level, user, ip);
            }
        }
        /// <summary>
        /// 日志记录到Db中。
        /// </summary>
        public virtual void LogToDb(string msg, string category = "", EnLogLevel level = EnLogLevel.Info, string user = "", string ip = "")
        {
            var sqlParams = new LogModal
            {
                Message = msg,
                Recorder = Recorder,
                LogLevel = level.ToString(),
                LogCategory = category,
                CreateTime = DateTime.Now,
                Thread = Thread.CurrentThread.ManagedThreadId,
                LogUser = user,
                Ip = ip
            };
            if (AsynThreadCount <= 0)
            {//同步处理
                DoInsertLogToDb(InsertLogSql, sqlParams);
            }
            else
            {//异步处理
                LogQueue.Add(sqlParams);
            }
        }

        /// <summary>
        /// 日志记录到txt中。
        /// </summary>
        /// <param name="msg">日志信息</param>
        /// <param name="category">自定义类别</param>
        /// <param name="level">日志等级：Info,Warn,Error,Fatal,Debug</param>
        /// <param name="user"></param>
        /// <param name="ip"></param>
        public virtual void LogToTxt(string msg, string category = "", EnLogLevel level = EnLogLevel.Info, string user = "", string ip = "")
        {
            var threadId = Thread.CurrentThread.ManagedThreadId;
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("[Thread]:{0} [Recorder]:{1} [Msg]:{2} ", threadId, Recorder, msg);
            if (!string.IsNullOrWhiteSpace(category))
            {
                sb.AppendFormat("[Category]:{0}", category);
            }
            if (level != EnLogLevel.Info)
            {
                sb.AppendFormat("[Level]:{0}", level.ToString());
            }
            if (!string.IsNullOrWhiteSpace(user))
            {
                sb.AppendFormat("[User]:{0}", user);
            }
            if (!string.IsNullOrWhiteSpace(ip))
            {
                sb.AppendFormat("[Ip]:{0}", ip);
            }

            if (AsynThreadCount <= 0)
            {//同步处理
                DoInsertLogToTxt(sb.ToString());
            }
            else
            {//异步处理
                LogQueue.Add(sb.ToString());
            }
        }
        private Object _lockWriteTxt = new object();
        /// <summary>
        /// 日志记录到txt中。
        /// (注意，此日志处理类，是为了支持普通量txt日志写入。如果是大并发写入txt，则要另外设计此场景的txt写入方式)
        /// </summary>
        /// <param name="strLog">需要记录的信息</param>
        public virtual void DoInsertLogToTxt(string strLog)
        {
            strLog = string.Format("{0} {1}", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), strLog);
            //每天一个txt文件，如果需要可以改成每小时一个文件
            string logPath = Path.Combine(DirectoryForTxt, string.Format(@"Log{0}.txt", DateTime.Now.ToString("yyyyMMdd")));
            lock (_lockWriteTxt)
            {
                //这边实现场景是一条一条日志记录。不适用大并发超大量txt写入，这种情况要另外设计此场景的txt写入方式，比如要考虑缓存队列、批次写入、故障处理等。
                using (FileStream fs = new FileStream(logPath, FileMode.OpenOrCreate, FileAccess.Write))
                {
                    using (StreamWriter sw = new StreamWriter(fs))
                    {
                        sw.BaseStream.Seek(0, SeekOrigin.End);
                        sw.WriteLine(strLog);
                        sw.Flush();
                    }
                }
            }
        }
        /// <summary>
        /// 日志写入Db和txt。
        /// </summary>
        /// <param name="msg">日志信息</param>
        /// <param name="category">自定义类别</param>
        /// <param name="level">日志等级：Info,Warn,Error,Fatal,Debug</param>
        /// <param name="user"></param>
        /// <param name="ip"></param>
        public virtual void LogToBoth(string msg, string category = "", EnLogLevel level = EnLogLevel.Info, string user = "", string ip = "")
        {
            try
            {
                LogToDb(msg, category, level, user, ip);
            }
            catch (Exception e)
            {
                LogToTxt("-------------执行LogToBoth中的LogToDb时异常:" + e.Message);
                LogToTxt(msg, category, level, user, ip);
                return;
            }
            LogToTxt(msg, category, level, user, ip);
        }
        #endregion

        /// <summary>
        /// 生成自定义异常消息，包含异常的堆栈
        /// </summary>
        /// <param name="ex">异常对象</param>
        /// <returns>异常字符串文本</returns>
        public static string GetExceptionDetailMsg(Exception ex)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("异常时间:{0}", DateTime.Now);
            sb.AppendFormat("异常信息:{0}", ex.Message);
            sb.AppendLine(string.Empty);
            sb.AppendFormat("异常堆栈:{0}", ex.StackTrace);
            sb.AppendLine(string.Empty);
            return sb.ToString();
        }
    }
}
