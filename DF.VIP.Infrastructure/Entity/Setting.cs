using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DF.VIP.Infrastructure.Entity
{
    public partial class Setting:BaseEntity
    {

        public int CompanyID { get; set; }

        [Required]
        [StringLength(50)]
        public string SettingKey { get; set; }

        [Required]
        [StringLength(50)]
        public string SettingValue { get; set; }

        public virtual Company Company { get; set; }
    }
}
