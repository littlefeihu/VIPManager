
namespace DF.VIP.Infrastructure.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Company:BaseEntity
    {
        [Required]
        [StringLength(50)]
        public string CompanyName { get; set; }

        [StringLength(50)]
        public string Remark { get; set; }

        [StringLength(50)]
        public string Phone { get; set; }

        public DateTime CreateTime { get; set; }

        [StringLength(50)]
        public string Mail { get; set; }

        [StringLength(30)]
        public string QQ { get; set; }

    
    }
}
