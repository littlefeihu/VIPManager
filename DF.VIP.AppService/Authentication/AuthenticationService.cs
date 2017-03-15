using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DF.VIP.AppService.Models;
using DF.VIP.Infrastructure.Entity;
using DF.VIP.Infrastructure.Repository;
using DF.VIP.Infrastructure.Security;
using DF.VIP.Infrastructure.Model;
using DF.VIP.Infrastructure.Authentication;

namespace DF.VIP.AppService.Authentication
{
    public class AuthenticationService : IAuthenticationService
    {
        ICommandRepository<LoginUser> cmdRepository;
        IQueryRepository<LoginUser> qRepository;
        IEncryptionService encryptionService;
        IFormsAuthenticationService formsAuthenticationService;
        public AuthenticationService(ICommandRepository<LoginUser> cmdRepository, IQueryRepository<LoginUser> qRepository, IEncryptionService encryptionService, IFormsAuthenticationService formsAuthenticationService)
        {
            this.formsAuthenticationService = formsAuthenticationService;
            this.cmdRepository = cmdRepository;
            this.qRepository = qRepository;
            this.encryptionService = encryptionService;
        }
        public void ForgetPassword(ForgetPasswordItem item)
        {
            throw new NotImplementedException();
        }



        private bool TryGetUser(out LoginUser user, LoginItem item)
        {
            var encryptedPwd = this.encryptionService.EncryptText(item.Password, "9FD84A6B-3345-4726-B4F6-4B5D8C3664AE");
            user = qRepository.Entities.Where(o => o.Phone == item.LoginPhone && o.Password == encryptedPwd && o.IsActive && !o.Locked).FirstOrDefault();

            return user != null;
        }

        private bool TryGetRoles(out List<SimpleRole> roles, LoginUser user)
        {
            roles = qRepository.Entities.First(o => o.ID == user.ID).UserRoles.Select(o => SimpleRole.CreateRole(o.RoleID, o.Role.RoleName)).ToList();
            return roles != null;
        }

        public SimpleUser Login(LoginItem item)
        {

            if (TryGetUser(out LoginUser user, item))
            {
                if (TryGetRoles(out List<SimpleRole> roles, user))
                {
                    user.Login();
                    var company = user.Company;
                    var simpleUser = SimpleUser.CreateUser(user.ID, user.NickName, new SimpleCompany { ID = company.ID, Name = company.CompanyName }, roles);
                    cmdRepository.SaveChanges();

                    this.formsAuthenticationService.Signin(simpleUser);

                    return simpleUser;
                }
            }
            return null;
        }
        public void SignOut()
        {
            this.formsAuthenticationService.SignOut();
        }
        public void Register(RegisterItem item)
        {
            if (qRepository.Entities.Any(o => o.Phone == item.RegisterPhone && o.IsActive && !o.Locked))
            {
                throw new Exception("user has exists");
            }

            var encryptedPassword = this.encryptionService.EncryptText(item.Password1, "9FD84A6B-3345-4726-B4F6-4B5D8C3664AE");

            var user = LoginUser.CreateUser(2, item.RegisterPhone, encryptedPassword);
            user.LockUser();
            this.cmdRepository.Insert(user);
            this.cmdRepository.SaveChanges();
        }
    }
}
