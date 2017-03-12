
using DF.VIP.Infrastructure.Entity.Admin;
using DF.VIP.Infrastructure.Entity.VipUser;

namespace DF.VIP.Infrastructure.Repository.Mapping
{
    public partial class VIPMemberMap : NopEntityTypeConfiguration<VIPMember>
    {
        public VIPMemberMap()
        {
            this.ToTable("VIPMember");
            this.HasKey(a => a.ID);
            this.HasRequired(o => o.VipLevel).WithMany(o => o.VIPMembers).HasForeignKey(o => o.VIPLevelID);
        }
    }
}
