
using DF.VIP.Infrastructure.Entity.Admin;

namespace DF.VIP.Infrastructure.Repository.Mapping
{
    public partial class ResourceMap : NopEntityTypeConfiguration<Resource>
    {
        public ResourceMap()
        {
            this.ToTable("Resource");
            this.HasKey(a => a.ID);
        }
    }
}
