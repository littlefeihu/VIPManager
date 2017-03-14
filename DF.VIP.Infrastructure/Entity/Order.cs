using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DF.VIP.Infrastructure.Entity
{
    public partial class Order:BaseEntity
    {
        public int CompanyID { get; set; }

        public int ProductID { get; set; }

        public int VipID { get; set; }

        public int Quantity { get; set; }

        public bool IsActive { get; set; }

        [StringLength(50)]
        public string Remark { get; set; }

        public DateTime CreateTime { get; set; }

        public DateTime UpdateTime { get; set; }

        public virtual Company Company { get; set; }

        public virtual Product Product { get; set; }

        public virtual VIPMember VIPMember { get; set; }
    }
}
