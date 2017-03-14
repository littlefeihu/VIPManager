
using DF.VIP.Infrastructure.Entity;

namespace DF.VIP.Infrastructure.Repository.Mapping
{
    public partial class RoleMap : NopEntityTypeConfiguration<Role>
    {
        public RoleMap()
        {
            this.ToTable("Role");
        }
    }
}
