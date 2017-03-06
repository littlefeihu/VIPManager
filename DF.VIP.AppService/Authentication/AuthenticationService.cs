using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DF.VIP.AppService.Models;
using DF.VIP.Infrastructure.Entity.Admin;
using DF.VIP.Infrastructure.Repository;

namespace DF.VIP.AppService.Authentication
{
    public class AuthenticationService : IAuthenticationService
    {
        ICommandRepository<LoginUser> cmdRepository;
        IQueryRepository<LoginUser> qRepository;
        public AuthenticationService(ICommandRepository<LoginUser> cmdRepository, IQueryRepository<LoginUser> qRepository)
        {
            this.cmdRepository = cmdRepository;
            this.qRepository = qRepository;
        }
        public void ForgetPassword(ForgetPasswordItem item)
        {
            throw new NotImplementedException();
        }

        public bool Login(LoginItem item)
        {
           var user= qRepository.Entities.Where(o => o.Phone == item.LoginPhone && o.Password == item.Password).FirstOrDefault();
            if(user!=null)
            {
                user.LastSignTime = DateTime.Now;
                cmdRepository.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }

        }

        public void Register(RegisterItem item)
        {
            var user = new LoginUser {
                CreateTime =DateTime.Now,
                IsActive =true,
                Locked=false,
                Password=item.Password1,
                Phone=item.RegisterPhone,
                UpdateTime=DateTime.Now,
                NickName="aa"
            };
            this.cmdRepository.Insert(user);
            this.cmdRepository.SaveChanges();
        }
    }
}
