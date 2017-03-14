
using DF.VIP.Infrastructure.Entity;

namespace DF.VIP.Infrastructure.Repository.Mapping
{
    public partial class VIPLevelMap : NopEntityTypeConfiguration<VIPLevel>
    {
        public VIPLevelMap()
        {
            this.ToTable("VIPLevel");

            this.HasRequired<Company>(o => o.Company).WithMany(o => o.VIPLevels).HasForeignKey(o=>o.CompanyID);
        }
    }
}
