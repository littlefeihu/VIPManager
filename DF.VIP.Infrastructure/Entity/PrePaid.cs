using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DF.VIP.Infrastructure.Entity
{
    public  partial class PrePaid : BaseEntity
    {
        public int CompanyID { get; set; }

        public int VIPID { get; set; }

        public decimal Amount { get; set; }

        public DateTime CreateTime { get; set; }

        public DateTime UpdateTime { get; set; }
    }
}
