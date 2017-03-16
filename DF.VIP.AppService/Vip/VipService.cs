using DF.VIP.AppService.Models;
using DF.VIP.Infrastructure.Entity;
using DF.VIP.Infrastructure.Model;
using DF.VIP.Infrastructure.Repository;
using System.Linq;

namespace DF.VIP.AppService.Vip
{
    public class VipService : IVipService
    {
        IQueryRepository<VIPMember> vipmemberQ;
        ICommandRepository<VIPMember> cmd;
        public VipService(IQueryRepository<VIPMember> vipmemberQ, ICommandRepository<VIPMember> cmd)
        {
            this.vipmemberQ = vipmemberQ;
            this.cmd = cmd;
        }

        public JqGridResult<VipMemberItem> SearchVipMembers(VipSearchRequest request, int companyid)
        {
            var baseResult = string.IsNullOrEmpty(request.Phone) ? this.vipmemberQ.Entities.Where(o => o.CompanyID == companyid) :
                this.vipmemberQ.Entities.Where(o => o.CompanyID == companyid && o.PhoneNum.Contains(request.Phone));
            int totalCount = baseResult.Count();

            var rows = baseResult.OrderBy(o => o.UpdateTime).Skip(request.SkipNum).Take(request.Rows).AsEnumerable().Select(o => new VipMemberItem
            {
                PhoneNum = o.PhoneNum,
                Amount = o.Amount,
                Gender = o.Gender ? "男" : "女",
                NickName = o.NickName,
                UpdateTime = o.UpdateTime.ToString("D"),
                Remark = o.Remark,
                ID = o.ID
            }).ToList();

            return new JqGridResult<VipMemberItem>(request.Rows, request.Page, totalCount, rows);
        }
        
        public VIPMember GetVipDetail(int vipid)
        {
          return this.vipmemberQ.Entities.FirstOrDefault(o => o.ID == vipid);
        }
       public void CreateVip(CreateVipRequest request)
        {
            var member = new VIPMember(request.CompanyID,request.Phone,request.Nickname,0,request.Levelid,string.Empty,request.Remark,true,request.Gender,request.Birthday,System.DateTime.Now,System.DateTime.Now,"","" );
            this.cmd.Insert(member);
            this.cmd.SaveChanges();
        }
    }
}
