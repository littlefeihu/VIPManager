using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DF.VIP.Infrastructure.Entity.VipUser
{
    public partial class CostRecord : BaseEntity
    {
        public virtual CostType CostType { get; set; }
        public virtual VIPMember VipMember { get; set; }
    }
}
