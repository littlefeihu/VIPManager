using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DF.VIP.Infrastructure.Configuration
{
    public interface IApplicationSettings
    {
        string LoggerName { get; }
      
         string TokenName { get; }

    }
}
