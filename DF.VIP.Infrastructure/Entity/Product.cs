using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DF.VIP.Infrastructure.Entity
{
    public partial class Product:BaseEntity
    {

        public int CompanyID { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public bool IsActive { get; set; }

        [StringLength(50)]
        public string Remark { get; set; }

        public DateTime CreateTime { get; set; }

        public DateTime? UpdateTime { get; set; }

        public virtual Company Company { get; set; }

        public virtual ICollection<Order> Orders { get; set; }

        public virtual ICollection<ProductStock> ProductStocks { get; set; }

       public virtual ICollection<ProductUsage> ProductUsages { get; set; }
    }
}
