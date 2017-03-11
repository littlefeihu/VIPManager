using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DF.VIP.Infrastructure.Entity.Admin
{
   public partial class Resource:BaseEntity
    {
   
        public string ResourceName { get; set; }
        public string ResourceValue { get; set; }
        public string Remark { get; set; }
        public bool IsActive { get; set; }
        public Int16 DisplayOrder { get; set; }
        public string Icon { get; set; }
        public int ParentID { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime UpdateTime { get; set; }

        public virtual ICollection<RoleAuthority> RoleAuthorities { set; get; }
    }
}
