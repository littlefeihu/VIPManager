using System.Configuration;

namespace DF.VIP.Infrastructure.Configuration
{
    public class ConfigApplicationSettings : IApplicationSettings
    {
        public string LoggerName
        {
            get { return ConfigurationManager.AppSettings["LoggerName"]; }
        }
        public string TokenName
        {
            get
            {
                return ConfigurationManager.AppSettings["TokenName"];
            }
        }
        
    }

}
