

using DF.VIP.Infrastructure.Entity;

namespace DF.VIP.Infrastructure.Repository.Mapping
{
    public partial class CompanyMap : NopEntityTypeConfiguration<Company>
    {
        public CompanyMap()
        {
            this.ToTable("Company");
        }
    }
}
