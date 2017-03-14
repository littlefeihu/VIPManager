
using DF.VIP.Infrastructure.Entity;

namespace DF.VIP.Infrastructure.Repository.Mapping
{
    public partial class ResourceMap : NopEntityTypeConfiguration<Resource>
    {
        public ResourceMap()
        {
            this.ToTable("Resource");
        }
    }
}
