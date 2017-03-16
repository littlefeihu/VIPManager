using DF.VIP.Infrastructure.Entity;
using DF.VIP.Infrastructure.Repository;
using System.Collections.Generic;
using System.Linq;

namespace DF.VIP.AppService.Products
{
    public class ProductService
    {
        IQueryRepository<Product> qProduct;
        ICommandRepository<Product> cmdProduct;
        public ProductService(IQueryRepository<Product> qProduct, ICommandRepository<Product> cmdProduct)
        {
            this.qProduct = qProduct;
            this.cmdProduct = cmdProduct;
        }

        public List<Product> GetAllProduct(string productName)
        {
            return this.qProduct.Entities.Where(o => o.Name.Contains(productName)).ToList();
        }

        public void CreateProduct(Product company)
        {
            this.cmdProduct.Insert(company);
            this.cmdProduct.SaveChanges();
        }

    }
}
