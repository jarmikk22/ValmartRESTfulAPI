using System;
using System.Collections.Generic;
using ValmartRESTfulAPI.Entities;

namespace ValmartRESTfulAPI.Repositories
{
    public class InMemProductsRepository : IProductRepository
    {
        private List<Product> products;

        public InMemProductsRepository()
        {
            products = new()
            {
                new Product
                {
                    Id = Guid.NewGuid(), Name = "Pepperidge Farm Herb Seasoned Classic Stuffing, 12 oz. Bag",
                    Brand = "Pepperidge Farm", Price = 34, CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = Guid.NewGuid(), Name = "Madd Gear Rize Light-Up Scooter - Pink",
                    Brand = "Madd Gear", Price = 15, CreatedDate = DateTime.Now
                },
            };
        }

        public IEnumerable<Product> getProducts()
        {
            return products;
        }
    }
    
}