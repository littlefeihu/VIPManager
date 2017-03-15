
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DF.VIP.Infrastructure.Entity
{
   public partial class VIPMember:BaseEntity
    {

        public virtual Company Company { get; set; }

       public virtual ICollection<CostRecord> CostRecords { get; set; }

        public virtual ICollection<Order> Orders { get; set; }

        public virtual ICollection<ProductStock> ProductStocks { get; set; }

        public virtual ICollection<ProductUsage> ProductUsages { get; set; }
        public virtual ICollection<PrePaid> PrePaids { get; set; }

        public virtual VIPLevel VIPLevel { get; set; }


    }
}
