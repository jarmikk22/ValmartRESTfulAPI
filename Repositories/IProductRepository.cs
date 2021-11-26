using System.Collections.Generic;
using ValmartRESTfulAPI.Entities;

namespace ValmartRESTfulAPI.Repositories
{
    public interface IProductRepository
    {
        public IEnumerable<Product> GetProducts();
        public void CreateProduct(Product product);
    }
}