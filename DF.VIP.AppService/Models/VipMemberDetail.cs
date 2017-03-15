using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DF.VIP.AppService.Models
{
    public class VipMemberDetail
    {
        public static  VipMemberDetail CreateVipMemberDetail(int id, string nickName, string phoneNum, decimal amount, bool gender, string birthday, DateTime createTime, DateTime updateTime, string remark)
        {
           return new VipMemberDetail(id, nickName, phoneNum, amount, gender, birthday, createTime, updateTime, remark);

        }

        public VipMemberDetail()
        {

        }
        public VipMemberDetail(int id, string nickName, string phoneNum, decimal amount, bool gender, string birthday, DateTime createTime, DateTime updateTime, string remark)
        {
            ID = id;
            NickName = nickName;
            PhoneNum = phoneNum;
            Amount = amount;
            Gender = gender?"男":"女";
            Birthday = birthday;
            CreateTime = createTime.ToString("D");
            UpdateTime = updateTime.ToString("D");
        }

        public int ID { get; set; }
        public string NickName { get; set; }
        public string PhoneNum { get; set; }
        public decimal Amount { get; set; }
        public string Gender { get; set; }
        public string Birthday { get; set; }
        public string CreateTime { get; set; }
        public string UpdateTime { get; set; }
        public string Remark { get; set; }
    }
}
