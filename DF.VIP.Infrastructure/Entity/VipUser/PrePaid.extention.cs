using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DF.VIP.Infrastructure.Entity.VipUser
{
    public  partial class PrePaid : BaseEntity
    {
        public virtual VIPMember VipMember { get; set; }
    }
}
