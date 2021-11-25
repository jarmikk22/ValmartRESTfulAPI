using ValmartRESTfulAPI.Dtos;
using ValmartRESTfulAPI.Entities;

namespace ValmartRESTfulAPI
{
    public static class Extensions
    {
        public static ProductDTO AsDTO(this Product product)
        {
            return new ProductDTO
            {
                Id = product.Id,
                Name = product.Name,
                Brand = product.Brand,
                Price = product.Price,
                CreatedDate = product.CreatedDate,
            };
        }
    }
}