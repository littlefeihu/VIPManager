
using DF.VIP.Infrastructure.Entity.Admin;

namespace DF.VIP.Infrastructure.Repository.Mapping
{
    public partial class RoleAuthorityMap : NopEntityTypeConfiguration<RoleAuthority>
    {
        public RoleAuthorityMap()
        {
            this.ToTable("RoleAuthority");
            this.HasKey(a => a.ID);
        }
    }
}
