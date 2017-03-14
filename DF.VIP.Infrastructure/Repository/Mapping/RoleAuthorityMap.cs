
using DF.VIP.Infrastructure.Entity;

namespace DF.VIP.Infrastructure.Repository.Mapping
{
    public partial class RoleAuthorityMap : NopEntityTypeConfiguration<RoleAuthority>
    {
        public RoleAuthorityMap()
        {
            this.ToTable("RoleAuthority");

            HasRequired(pt => pt.Resource).WithMany(p => p.RoleAuthorities).HasForeignKey(pt => pt.ResourceID).WillCascadeOnDelete(false);
            HasRequired(pt => pt.Role).WithMany(t => t.RoleAuthorities).HasForeignKey(pt => pt.RoleID).WillCascadeOnDelete(false);
        }
    }
}
