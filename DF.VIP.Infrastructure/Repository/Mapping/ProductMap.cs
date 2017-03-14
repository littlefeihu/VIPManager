using DF.VIP.Infrastructure.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DF.VIP.Infrastructure.Repository.Mapping
{
    public class ProductMap : NopEntityTypeConfiguration<Product>
    {
        public ProductMap()
        {
            this.ToTable("Product");

            this.HasRequired(o => o.Company).WithMany(o => o.Products).HasForeignKey(o => o.CompanyID);


        }
    }
}
