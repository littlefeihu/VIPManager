using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DF.VIP.Infrastructure.Entity.VipUser
{
    public class CostRecord : BaseEntity
    {
        int vipID;
        int costTypeID;
        decimal cost;
        int remark;
        DateTime createTime;

        public int VipID { get => vipID; set => vipID = value; }
        public int CostTypeID { get => costTypeID; set => costTypeID = value; }
        public decimal Cost { get => cost; set => cost = value; }
        public int Remark { get => remark; set => remark = value; }
        public DateTime CreateTime { get => createTime; set => createTime = value; }

        public virtual CostType CostType { get; set; }
        public virtual VIPMember VipMember { get; set; }
    }
}
