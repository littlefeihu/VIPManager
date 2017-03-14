using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DF.VIP.Infrastructure.Entity
{
    public partial class CostRecord : BaseEntity
    {
        public int VipID { get; set; }

        public decimal Cost { get; set; }

        [StringLength(50)]
        public string Remark { get; set; }

        public DateTime CreateTime { get; set; }

    }
}
