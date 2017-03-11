using DF.VIP.Infrastructure.Entity.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DF.VIP.Infrastructure.Entity.VipUser
{
    public class CostType:BaseEntity
    {
        int userID;
        string costTypeName;
        float costValue;
        bool isActive;
        string remark;
        DateTime createTime;

        public int UserID { get => userID; set => userID = value; }
        public string CostTypeName { get => costTypeName; set => costTypeName = value; }
        public float CostValue { get => costValue; set => costValue = value; }
        public bool IsActive { get => isActive; set => isActive = value; }
        public string Remark { get => remark; set => remark = value; }
        public DateTime CreateTime { get => createTime; set => createTime = value; }

        public virtual LoginUser User { get; set; }

        public virtual ICollection<CostRecord> CostRecords { get; set; }
    }
}
