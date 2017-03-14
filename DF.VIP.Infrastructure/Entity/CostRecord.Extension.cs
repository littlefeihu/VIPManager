using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DF.VIP.Infrastructure.Entity
{
    public partial class CostRecord : BaseEntity
    {
        public virtual VIPMember VIPMember { get; set; }
    }
}
