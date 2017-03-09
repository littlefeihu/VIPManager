
using DF.VIP.Infrastructure.Entity.Admin;

namespace DF.VIP.Infrastructure.Repository.Mapping
{
    public partial class UserRoleMap : NopEntityTypeConfiguration<UserRole>
    {
        public UserRoleMap()
        {
            this.ToTable("UserRole");
            this.HasKey(a => a.ID);
            HasRequired(pt => pt.User).WithMany(p => p.UserRoles).HasForeignKey(pt => pt.UserID).WillCascadeOnDelete(false);
            HasRequired(pt => pt.Role).WithMany(t => t.UserRoles).HasForeignKey(pt => pt.RoleID).WillCascadeOnDelete(false);
        }
    }
}
