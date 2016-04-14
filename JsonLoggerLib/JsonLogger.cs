using log4net;
using Newtonsoft.Json;
using System;

namespace Reselbob.Logentries
{
    public class JsonLogger
    {
        private static readonly ILog log =
   LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private static log4net.Appender.LogentriesAppender app; //This is a hack to get the logentries stuff to copy into the executing bin

        static JsonLogger()
        {
            //Bind to the Log4Net configuration
            log4net.Config.XmlConfigurator.Configure();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T">a POCO that serves as a data holder
        /// that will container log entry information</typeparam>
        /// <param name="objectToLog">The POCO containing information to log</param>
        /// <param name="level">a value of <seealso cref="LogLevel"/> that declares
        /// the logging level</param>
        public static void Log<T>(T objectToLog, LogLevel level = LogLevel.Info)
        {
            var obj = JsonConvert.SerializeObject(objectToLog);
            switch (level)
            {
                case LogLevel.Debug:
                    log.Debug(obj);
                    break;
                case LogLevel.Error:
                    log.Error(obj);
                    break;
                case LogLevel.Fatal:
                    log.Fatal(obj);
                    break;
                case LogLevel.Info:
                    log.Info(obj);
                    break;
                case LogLevel.Warn:
                    log.Warn(obj);
                    break;
                default:
                    throw new ArgumentOutOfRangeException("level", level, null);
            }
        }
    }
    /// <summary>
    /// An enum that is used for declaring logging level
    /// </summary>
    public enum LogLevel
    {
        Debug,
        Error,
        Fatal,
        Info,
        Warn
    }
}
