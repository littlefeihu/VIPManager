using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DF.VIP.Infrastructure.Entity
{
   public partial class MsgTemplate:BaseEntity
    {
        public int CompanyID { get; set; }

        [Required]
        [StringLength(50)]
        public string TemplateContent { get; set; }

        public bool IsActive { get; set; }

        public DateTime CreateTime { get; set; }

        [Required]
        [StringLength(50)]
        public string CreateBy { get; set; }

        public DateTime UpdateTime { get; set; }

        [Required]
        [StringLength(50)]
        public string UpdateBy { get; set; }
    }
}
