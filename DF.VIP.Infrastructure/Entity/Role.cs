
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DF.VIP.Infrastructure.Entity
{
   public partial class Role: BaseEntity
    {
     
        public string RoleName { get; set; }
        public string Remark { get; set; }

        public DateTime CreateTime { get; set; }
        public DateTime UpdateTime { get; set; }

    }
}
