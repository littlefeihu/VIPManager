using DF.VIP.AppService.Models;
using DF.VIP.Infrastructure.Model;
using DF.VIP.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DF.VIP.AppService.Vip
{
    public interface IVipService
    {
        JqGridResult<VipMemberItem> SearchVipMembers(JqGridSearchRequest request, int userid);
    }
}
