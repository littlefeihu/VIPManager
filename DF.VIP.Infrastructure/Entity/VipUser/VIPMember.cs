using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DF.VIP.Infrastructure.Entity.VipUser
{
   public partial class VIPMember:BaseEntity
    {
      
        public int UserID { get; set; }
        public int VIPLevelID { get; set; }
        public string PhoneNum { get; set; }
        public string IdentityID { get; set; }
        public string Remark { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}
