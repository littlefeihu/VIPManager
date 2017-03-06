using DF.VIP.AppService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DF.VIP.AppService.Authentication
{
   public interface IAuthenticationService
    {
        bool Login(LoginItem item);
        void Register(RegisterItem item);
        void ForgetPassword(ForgetPasswordItem item);
    }
}
