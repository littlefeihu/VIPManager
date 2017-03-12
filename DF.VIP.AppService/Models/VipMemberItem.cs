using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DF.VIP.AppService.Models
{
    public class VipMemberItem
    {
        public string PhoneNum { get; set; }
        public string NickName { get; set; }
        public string Gender { get; set; }
        public decimal Amount { get; set; }
        public string UpdateTime { get; set; }
        public string Remark { get; set; }
    }
}
