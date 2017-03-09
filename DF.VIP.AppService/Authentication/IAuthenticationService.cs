using DF.VIP.AppService.Models;
using DF.VIP.Infrastructure.Entity.Admin;
using DF.VIP.Infrastructure.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DF.VIP.AppService.Authentication
{
   public interface IAuthenticationService
    {
        SimpleUser Login(LoginItem item);
        void Register(RegisterItem item);
        void ForgetPassword(ForgetPasswordItem item);
        void SignOut();
    }
}
