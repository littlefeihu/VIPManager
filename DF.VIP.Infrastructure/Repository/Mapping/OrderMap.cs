

using DF.VIP.Infrastructure.Entity;

namespace DF.VIP.Infrastructure.Repository.Mapping
{
    public partial class OrderMap : NopEntityTypeConfiguration<Order>
    {
        public OrderMap()
        {
            this.ToTable("Order");
            this.HasRequired(o => o.Company).WithMany(o => o.Orders).HasForeignKey(o => o.CompanyID);
            this.HasRequired(o => o.Product).WithMany(o => o.Orders).HasForeignKey(o => o.ProductID);
            this.HasRequired(o => o.VIPMember).WithMany(o => o.Orders).HasForeignKey(o => o.VipID);

        }
    }
}
