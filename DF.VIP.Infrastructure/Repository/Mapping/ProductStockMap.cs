

using DF.VIP.Infrastructure.Entity;

namespace DF.VIP.Infrastructure.Repository.Mapping
{
    public partial class ProductStockMap : NopEntityTypeConfiguration<ProductStock>
    {
        public ProductStockMap()
        {
            this.ToTable("ProductStock");
            this.HasRequired(o => o.Company).WithMany(o => o.ProductStocks).HasForeignKey(o => o.CompanyID);
            this.HasRequired(o => o.Product).WithMany(o => o.ProductStocks).HasForeignKey(o => o.ProductID);
            this.HasRequired(o => o.VIPMember).WithMany(o => o.ProductStocks).HasForeignKey(o => o.VipID);

        }
    }
}
