using DF.VIP.Infrastructure.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DF.VIP.Infrastructure.Repository.Mapping
{
    public class PrePaidMap : NopEntityTypeConfiguration<PrePaid>
    {
        public PrePaidMap()
        {
            this.ToTable("PrePaid");

            this.HasRequired(o=>o.VipMember).WithMany(o => o.PrePaids).HasForeignKey(o => o.VIPID);
            this.HasRequired(o => o.Company).WithMany(o => o.PrePaids).HasForeignKey(o => o.CompanyID);


        }
    }
}
