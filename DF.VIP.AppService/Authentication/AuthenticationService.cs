using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DF.VIP.AppService.Models;
using DF.VIP.Infrastructure.Entity.Admin;
using DF.VIP.Infrastructure.Repository;
using DF.VIP.Infrastructure.Security;

namespace DF.VIP.AppService.Authentication
{
    public class AuthenticationService : IAuthenticationService
    {
        ICommandRepository<LoginUser> cmdRepository;
        IQueryRepository<LoginUser> qRepository;
        IEncryptionService encryptionService;
        public AuthenticationService(ICommandRepository<LoginUser> cmdRepository, IQueryRepository<LoginUser> qRepository, IEncryptionService encryptionService)
        {
            this.cmdRepository = cmdRepository;
            this.qRepository = qRepository;
            this.encryptionService = encryptionService;
        }
        public void ForgetPassword(ForgetPasswordItem item)
        {
            throw new NotImplementedException();
        }

        public bool Login(LoginItem item)
        {
            var encryptedPwd = this.encryptionService.EncryptText(item.Password, "9FD84A6B-3345-4726-B4F6-4B5D8C3664AE");
            var user = qRepository.Entities.Where(o => o.Phone == item.LoginPhone && o.Password == encryptedPwd && o.IsActive && !o.Locked).FirstOrDefault();
            if (user != null)
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
            if (qRepository.Entities.Any(o => o.Phone == item.RegisterPhone && o.IsActive && !o.Locked))
            {
                throw new Exception("user has exists");
            }
            var user = new LoginUser
            {
                CreateTime = DateTime.Now,
                IsActive = true,
                Locked = false,
                Password = this.encryptionService.EncryptText(item.Password1, "9FD84A6B-3345-4726-B4F6-4B5D8C3664AE"),
                Phone = item.RegisterPhone,
                UpdateTime = DateTime.Now,
                NickName = "aa"
            };
            this.cmdRepository.Insert(user);
            this.cmdRepository.SaveChanges();
        }
    }
}
