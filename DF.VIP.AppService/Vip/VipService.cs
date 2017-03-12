using DF.VIP.AppService.Models;
using DF.VIP.Infrastructure.Entity.VipUser;
using DF.VIP.Infrastructure.Model;
using DF.VIP.Infrastructure.Models;
using DF.VIP.Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DF.VIP.AppService.Vip
{
    public class VipService: IVipService
    {
        IQueryRepository<VIPMember> vipmemberQ;
        public VipService(IQueryRepository<VIPMember> vipmemberQ)
        {
            this.vipmemberQ = vipmemberQ;
        }

        public JqGridResult<VipMemberItem> SearchVipMembers(JqGridSearchRequest request,int userid)
        {
            var baseResult =string.IsNullOrEmpty(request.Phone)? this.vipmemberQ.Entities.Where(o => o.UserID == userid): 
                this.vipmemberQ.Entities.Where(o => o.UserID == userid&&o.PhoneNum.Contains(request.Phone));
            int totalCount = baseResult.Count();

          var rows=  baseResult.OrderBy(o => o.UpdateTime).Skip(request.SkipNum).Take(request.Rows).AsEnumerable().Select(o => new VipMemberItem
            {
                PhoneNum = o.PhoneNum,
                Amount = o.Amount,
                Gender = o.Gender?"男":"女",
                NickName = o.NickName,
                UpdateTime = o.UpdateTime.ToString("D"),
                Remark = o.Remark
            }).ToList();
            
            return new JqGridResult<VipMemberItem>(request.Rows,request.Page,totalCount, rows);
        }
    }
}
