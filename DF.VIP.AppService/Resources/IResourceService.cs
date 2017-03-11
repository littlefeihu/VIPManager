using DF.VIP.AppService.Models;
using DF.VIP.Infrastructure.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DF.VIP.AppService.Resources
{
   public interface IResourceService
    {
        List<NavigatorModel> GetAuthorisedNavigator(SimpleUser user);
    }
}
