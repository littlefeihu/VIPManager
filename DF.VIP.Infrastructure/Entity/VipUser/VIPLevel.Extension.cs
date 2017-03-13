using DF.VIP.Infrastructure.Entity.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DF.VIP.Infrastructure.Entity.VipUser
{
    public partial class VIPLevel : BaseEntity
    {
        public virtual LoginUser User { get; set; }

        public virtual ICollection<VIPMember> VIPMembers { get; set; }
    }
}
