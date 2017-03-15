
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DF.VIP.Infrastructure.Entity
{
   public partial class VIPMember:BaseEntity
    {
        public VIPMember()
        {

        }
        public VIPMember(int companyID, string phoneNum, string nickName, decimal amount, int vIPLevelID, string identityID, string remark, bool isActive, bool gender, string birthday, DateTime createTime, DateTime updateTime, string createBy, string updateBy)
        {
            CompanyID = companyID;
            PhoneNum = phoneNum;
            NickName = nickName;
            Amount = amount;
            VIPLevelID = vIPLevelID;
            IdentityID = identityID;
            Remark = remark;
            IsActive = isActive;
            Gender = gender;
            Birthday = birthday;
            CreateTime = createTime;
            UpdateTime = updateTime;
            CreateBy = createBy;
            UpdateBy = updateBy;
        }

        public int CompanyID { get; set; }

        [Required]
        [StringLength(20)]
        public string PhoneNum { get; set; }

        [Required]
        [StringLength(50)]
        public string NickName { get; set; }

        public decimal Amount { get; set; }

        public int VIPLevelID { get; set; }

        [StringLength(50)]
        public string IdentityID { get; set; }

        [StringLength(50)]
        public string Remark { get; set; }

        public bool IsActive { get; set; }

        public bool Gender { get; set; }

        public string Birthday { get; set; }

        public DateTime CreateTime { get; set; }

        public DateTime UpdateTime { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] RowVersion { get; set; }

        [StringLength(50)]
        public string CreateBy { get; set; }

        [StringLength(50)]
        public string UpdateBy { get; set; }
    }
}
