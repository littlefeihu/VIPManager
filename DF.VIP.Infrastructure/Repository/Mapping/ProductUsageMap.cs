

using DF.VIP.Infrastructure.Entity;

namespace DF.VIP.Infrastructure.Repository.Mapping
{
    public partial class ProductUsageMap : NopEntityTypeConfiguration<ProductUsage>
    {
        public ProductUsageMap()
        {
            this.ToTable("ProductUsage");
            this.HasRequired(o => o.Company).WithMany(o => o.ProductUsages).HasForeignKey(o => o.CompanyID);
            this.HasRequired(o => o.Product).WithMany(o => o.ProductUsages).HasForeignKey(o => o.ProductID);
            this.HasRequired(o => o.VIPMember).WithMany(o => o.ProductUsages).HasForeignKey(o => o.VipID);

        }
    }
}
