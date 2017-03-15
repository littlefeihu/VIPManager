using DF.VIP.Infrastructure.Binder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace DF.VIP.Infrastructure.Model
{
    [ModelBinder(typeof(CreateVipRequestBinder))]
    public class CreateVipRequest
    {
        string phone;
        string nickname;
        bool gender;
        int levelid;
        string remark;

        public string Phone { get => phone; set => phone = value; }
        public string Nickname { get => nickname; set => nickname = value; }
        public bool Gender { get => gender; set => gender = value; }
        public int Levelid { get => levelid; set => levelid = value; }
        public string Birthday { get; set; }
        public string Remark { get => remark; set => remark = value; }

        public int CompanyID { get; set; }
    }
}
