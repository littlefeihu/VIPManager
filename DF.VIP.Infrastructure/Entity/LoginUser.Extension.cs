using System;
using System.Collections.Generic;

namespace DF.VIP.Infrastructure.Entity
{
    public partial class LoginUser
    {
        public virtual Company Company { get; set; }

        public virtual ICollection<MsgTrace> MsgTraces { get; set; }

         public virtual ICollection<UserRole> UserRoles { get; set; }

        public void EncryptPassword(string encryptedPassword)
        {
            this.Password = encryptedPassword;
        }

        public void Login()
        {
            this.LastSignTime = DateTime.Now;
        }

        public void LockUser()
        {
            this.Locked = true;
        }

        public static LoginUser CreateUser(int companyid, string phone, string encryptedpassword)
        {
            return new LoginUser
            {
                CompanyID=companyid,
                Phone = phone,
                Password = encryptedpassword,
                NickName = phone,
                IsActive = true,
                Locked = false,
                CreateTime = DateTime.Now,
                UpdateTime = DateTime.Now,
            };
        }

    }
}
