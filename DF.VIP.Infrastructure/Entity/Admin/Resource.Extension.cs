using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DF.VIP.Infrastructure.Entity.Admin
{
   public partial class Resource:BaseEntity
    {
        public virtual ICollection<RoleAuthority> RoleAuthorities { set; get; }
    }
}
