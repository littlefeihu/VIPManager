
using DF.VIP.Infrastructure.Entity;

namespace DF.VIP.Infrastructure.Repository.Mapping
{
    public partial class VIPMemberMap : NopEntityTypeConfiguration<VIPMember>
    {
        public VIPMemberMap()
        {
            this.ToTable("VIPMember");
            this.HasRequired(o => o.Company).WithMany(o => o.VIPMembers).HasForeignKey(o => o.CompanyID);
            this.HasRequired(o => o.VIPLevel).WithMany(o => o.VIPMembers).HasForeignKey(o => o.VIPLevelID);

        }
    }
}
