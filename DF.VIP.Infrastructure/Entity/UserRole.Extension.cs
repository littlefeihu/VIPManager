using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DF.VIP.Infrastructure.Entity
{
    public  partial class UserRole:BaseEntity
    {
        public virtual LoginUser User { set; get; }
        public virtual Role Role { set; get; }
    }
}
