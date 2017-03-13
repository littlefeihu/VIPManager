using DF.VIP.Infrastructure.Entity.VipUser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DF.VIP.Infrastructure.Entity.Admin
{
   public partial class LoginUser
    {
        public virtual ICollection<UserRole> UserRoles { set; get; }

        public virtual ICollection<VIPLevel> VipLevels { get; set; }

        public virtual ICollection<CostType> CostTypes { get; set; }

        public void EncryptPassword(string encryptedPassword)
        {
            this.Password = encryptedPassword;
        }

        public void Login()
        {
            this.LastSignTime = DateTime.Now;
        }

        public static LoginUser CreateUser(string phone, string encryptedpassword)
        {
            return new LoginUser
            {
                CreateTime = DateTime.Now,
                IsActive = true,
                Locked = false,
                Password = encryptedpassword,
                Phone = phone,
                UpdateTime = DateTime.Now,
                NickName = phone
            };
        }
    }
}
