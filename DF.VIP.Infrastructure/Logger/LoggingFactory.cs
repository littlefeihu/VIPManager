using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DF.VIP.Infrastructure.Logger
{
    public class LoggingFactory
    {
        private static ILogger _logger;

        public  LoggingFactory(ILogger logger)
        {
            _logger = logger;
        }

        public static ILogger GetLogger()
        {
            return _logger;
        }
    }
}
