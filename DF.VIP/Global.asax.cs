
using DF.VIP.Infrastructure;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace DF.VIP
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            var config = ConfigurationManager.GetSection("NopConfig") as NopConfig;
            VipEngine.Instance.Initialize(config);
        }
        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            var webHelper = VipEngine.Instance.Resolve<IWebHelper>();
            if (webHelper.IsStaticResource(this.Request))
                return;

        }
        protected void Application_EndRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {
            if (HttpContext.Current.User != null)
            {
                Console.WriteLine(HttpContext.Current.User);
            }
        }

        protected void Application_Error(Object sender, EventArgs e)
        {

        }
    }
}
