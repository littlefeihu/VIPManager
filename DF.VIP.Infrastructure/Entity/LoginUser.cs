using System;
using System.ComponentModel.DataAnnotations;

namespace DF.VIP.Infrastructure.Entity
{
    public partial class LoginUser: BaseEntity
    {
        public int CompanyID { get; set; }

        [StringLength(20)]
        public string Phone { get; set; }

        [StringLength(50)]
        public string Password { get; set; }

        public DateTime? LastSignTime { get; set; }

        [StringLength(50)]
        public string NickName { get; set; }

        public bool Locked { get; set; }

        public bool IsActive { get; set; }

        public DateTime CreateTime { get; set; }

        public DateTime UpdateTime { get; set; }



    }
}
