using DF.VIP.Infrastructure.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Security;

namespace DF.VIP.Infrastructure.Authentication
{
    public interface IFormsAuthenticationService
    {
        void Signin(SimpleUser user);
        void SignOut();
        SimpleUser GetAuthenticatedCustomer();
        void SetCurrentUser();
    }

   public class FormsAuthenticationService: IFormsAuthenticationService
    {
        private SimpleUser _cachedUser;
        private readonly HttpContextBase httpContext;
        public FormsAuthenticationService(HttpContextBase httpContext)
        {
            this.httpContext = httpContext;
        }

        public void Signin(SimpleUser user)
        {
            var now = DateTime.Now;
            var ticket = new FormsAuthenticationTicket(
            1 /*version*/,
            user.UserName,
            now,
            now.Add(new TimeSpan(0, 30, 0)),
            false,
            JsonHelper.JsonSerializer(user),
            FormsAuthentication.FormsCookiePath);

            var encryptedTicket = FormsAuthentication.Encrypt(ticket);

            var cookie = new HttpCookie(FormsAuthentication.FormsCookieName, encryptedTicket);
            cookie.HttpOnly = true;
            if (ticket.IsPersistent)
            {
                cookie.Expires = ticket.Expiration;
            }
            cookie.Secure = FormsAuthentication.RequireSSL;
            cookie.Path = FormsAuthentication.FormsCookiePath;
            if (FormsAuthentication.CookieDomain != null)
            {
                cookie.Domain = FormsAuthentication.CookieDomain;
            }
            httpContext.Response.Cookies.Add(cookie);
            _cachedUser = user;
        }
        public virtual void SignOut()
        {
            _cachedUser = null;
            FormsAuthentication.SignOut();
        }

        public virtual SimpleUser GetAuthenticatedCustomer()
        {
            if (_cachedUser != null)
                return _cachedUser;

            if (httpContext == null ||
                httpContext.Request == null ||
                !httpContext.Request.IsAuthenticated ||
                !(httpContext.User.Identity is FormsIdentity))
            {
                return null;
            }

            var formsIdentity = (FormsIdentity)httpContext.User.Identity;
            var customer = GetAuthenticatedCustomerFromTicket(formsIdentity.Ticket);
         
                _cachedUser = customer;
            return _cachedUser;
        }

        protected virtual SimpleUser GetAuthenticatedCustomerFromTicket(FormsAuthenticationTicket ticket)
        {
            if (ticket == null)
                throw new ArgumentNullException("ticket");

            return JsonHelper.JsonDeserialize<SimpleUser>(ticket.UserData);
        }

       public void SetCurrentUser()
        {
            if (httpContext == null ||
            httpContext.Request == null ||
            !httpContext.Request.IsAuthenticated ||
            !(httpContext.User.Identity is FormsIdentity))
            {
                return ;
            }
            var formsIdentity = (FormsIdentity)httpContext.User.Identity;
            httpContext.User = new VipFormPrincipal(formsIdentity.Ticket, GetAuthenticatedCustomerFromTicket(formsIdentity.Ticket));
        }
    }
}
