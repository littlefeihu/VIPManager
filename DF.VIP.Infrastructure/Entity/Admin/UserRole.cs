using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DF.VIP.Infrastructure.Entity.Admin
{
    public  partial class UserRole:BaseEntity
    {
     
        public int UserID { get; set; }
        public int RoleID { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime UpdateTime { get; set; }

        public virtual LoginUser User { set; get; }
        public virtual Role Role { set; get; }
    }
}
