using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DF.VIP.Infrastructure.Entity
{
    public  partial class RoleAuthority:BaseEntity
    {
    
        public int ResourceID { get; set; }
        public int RoleID { get; set; }
        public bool IsActive { get; set; }

        public DateTime CreateTime { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}
