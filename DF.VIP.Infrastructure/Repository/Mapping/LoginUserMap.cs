

using DF.VIP.Infrastructure.Entity;

namespace DF.VIP.Infrastructure.Repository.Mapping
{
    public partial class LoginUserMap : NopEntityTypeConfiguration<LoginUser>
    {
        public LoginUserMap()
        {
            this.ToTable("LoginUser");
            this.HasRequired(o => o.Company).WithMany(o => o.LoginUsers).HasForeignKey(o => o.CompanyID);
        }
    }
}
