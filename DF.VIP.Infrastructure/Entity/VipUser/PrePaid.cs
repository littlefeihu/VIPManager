using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DF.VIP.Infrastructure.Entity.VipUser
{
    public  class PrePaid : BaseEntity
    {
        int vipID;
        float amount;
        bool isActive;
        DateTime createTime;
        DateTime updateTime;
        byte[] lSST;

        public int VipID { get => vipID; set => vipID = value; }
        public float Amount { get => amount; set => amount = value; }
        public bool IsActive { get => isActive; set => isActive = value; }
        public DateTime CreateTime { get => createTime; set => createTime = value; }
        public DateTime UpdateTime { get => updateTime; set => updateTime = value; }
        public byte[] LSST { get => lSST; set => lSST = value; }

        public virtual VIPMember VipMember { get; set; }
    }
}
