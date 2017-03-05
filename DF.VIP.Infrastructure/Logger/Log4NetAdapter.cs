using DF.VIP.Infrastructure.Configuration;
using log4net;
using log4net.Config;
using System.IO;

namespace DF.VIP.Infrastructure.Logger
{
    public class Log4NetAdapter : ILogger
    {
        private static log4net.ILog _log;

        static Log4NetAdapter()
        {
            var logpath = Path.Combine(System.AppDomain.CurrentDomain.RelativeSearchPath, "log4net.config");
            log4net.Config.XmlConfigurator.Configure(new System.IO.FileInfo(logpath));
            XmlConfigurator.Configure();
            _log = LogManager
             .GetLogger(ApplicationSettingsFactory.GetApplicationSettings().LoggerName);
        }

        public void Log(string message)
        {
            _log.Info(message);
        }
    }

}
