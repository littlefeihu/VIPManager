using DF.VIP.Infrastructure.Entity.VipUser;
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
            this.ToTable("PrePaid").HasRequired<VIPMember>(o=>o.VipMember).WithMany(o => o.PrePaids).HasForeignKey(o => o.VipID);

        }
    }
}
