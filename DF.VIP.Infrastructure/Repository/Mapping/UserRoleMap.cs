
using DF.VIP.Infrastructure.Entity.Admin;

namespace DF.VIP.Infrastructure.Repository.Mapping
{
    public partial class UserRoleMap : NopEntityTypeConfiguration<UserRole>
    {
        public UserRoleMap()
        {
            this.ToTable("UserRole");
            this.HasKey(a => a.ID);
        }
    }
}
