
using DF.VIP.Infrastructure.Entity.Admin;

namespace DF.VIP.Infrastructure.Repository.Mapping
{
    public partial class LoginUserMap : NopEntityTypeConfiguration<LoginUser>
    {
        public LoginUserMap()
        {
            this.ToTable("LoginUser");
            this.HasKey(a => a.ID);
        }
    }
}
