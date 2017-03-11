
using DF.VIP.Infrastructure.Entity.Admin;
using DF.VIP.Infrastructure.Entity.VipUser;

namespace DF.VIP.Infrastructure.Repository.Mapping
{
    public partial class CostTypeMap : NopEntityTypeConfiguration<CostType>
    {
        public CostTypeMap()
        {
            this.ToTable("CostType").HasKey(o => o.ID).HasRequired<LoginUser>(o=>o.User).WithMany(o=>o.CostTypes).HasForeignKey(o=>o.UserID);
        }
    }
}
