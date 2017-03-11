
using DF.VIP.Infrastructure.Entity.Admin;

namespace DF.VIP.Infrastructure.Repository.Mapping
{
    public partial class LoginUserMap : NopEntityTypeConfiguration<LoginUser>
    {
        public LoginUserMap()
        {
            this.ToTable("LoginUser").HasKey(o => o.ID);
        }
    }
}
