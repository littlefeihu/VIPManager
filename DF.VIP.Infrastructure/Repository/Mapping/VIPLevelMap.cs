
using DF.VIP.Infrastructure.Entity.Admin;
using DF.VIP.Infrastructure.Entity.VipUser;

namespace DF.VIP.Infrastructure.Repository.Mapping
{
    public partial class VIPLevelMap : NopEntityTypeConfiguration<VIPLevel>
    {
        public VIPLevelMap()
        {
            this.ToTable("VIPLevel");
            this.HasKey(a => a.ID);

            this.HasRequired<LoginUser>(o => o.User).WithMany(o => o.VipLevels).HasForeignKey(o=>o.UserID);
        }
    }
}
