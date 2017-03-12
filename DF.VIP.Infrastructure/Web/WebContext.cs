using DF.VIP.Infrastructure.Authentication;
using DF.VIP.Infrastructure.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace DF.VIP.Infrastructure.Web
{
   public class WebContext : IWebContext
    {
        private readonly HttpContextBase _httpContext;

        public WebContext(HttpContextBase httpContext)
        {
            _httpContext = httpContext;
        }

        public SimpleUser CurrentUser
        {
            get
            {
                var user = _httpContext.User as VipFormPrincipal;
                if (user != null)
                {
                    return user.UserData;
                }
                return null;
            }
        }
    }
}
