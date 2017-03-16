using DF.VIP.AppService.Models;
using DF.VIP.Infrastructure.Entity;
using DF.VIP.Infrastructure.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DF.VIP.AppService.Vip
{
    public interface IVipService
    {
        JqGridResult<VipMemberItem> SearchVipMembers(VipSearchRequest request, int companyid);

        VIPMember GetVipDetail(int vipid);

        void CreateVip(CreateVipRequest request);
    }
}
