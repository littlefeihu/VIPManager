using DF.VIP.Infrastructure.Entity.VipUser;
using DF.VIP.Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DF.VIP.Infrastructure.Entity.Admin
{
    public partial class LoginUser: BaseEntity
    {
       
        private string phone;
        private string password;
        private DateTime? lastSignTime;
        private string nickName;
        private bool locked;
        private bool isActive;
        private int msgCount;
        private int msgConsumedCount;

     
        public string Phone { get => phone; set => phone = value; }
        public string Password { get => password; set => password = value; }
        public DateTime? LastSignTime { get => lastSignTime; set => lastSignTime = value; }
        public string NickName { get => nickName; set => nickName = value; }
        public bool Locked { get => locked; set => locked = value; }
        public bool IsActive { get => isActive; set => isActive = value; }
        public int MsgCount { get => msgCount; set => msgCount = value; }
        public int MsgConsumedCount { get => msgConsumedCount; set => msgConsumedCount = value; }
        public DateTime CreateTime { get; set; }
        public DateTime UpdateTime { get; set; }

        public void EncryptPassword(string encryptedPassword)
        {
            this.Password = encryptedPassword;
        }


        public void Login()
        {
            this.LastSignTime = DateTime.Now;
        }

     

        public static LoginUser CreateUser(string phone,string encryptedpassword)
        {
          return  new LoginUser
            {
                CreateTime = DateTime.Now,
                IsActive = true,
                Locked = false,
                Password = encryptedpassword,
                Phone = phone,
                UpdateTime = DateTime.Now,
                NickName =phone
            };
        }


        public virtual ICollection<UserRole> UserRoles { set; get; }

        public virtual ICollection<VIPLevel> VipLevels { get; set; }

        public virtual ICollection<CostType> CostTypes { get; set; }

    }
}
