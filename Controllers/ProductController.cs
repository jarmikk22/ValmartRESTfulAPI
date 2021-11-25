using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ValmartRESTfulAPI.Dtos;
using ValmartRESTfulAPI.Entities;
using ValmartRESTfulAPI.Repositories;

namespace ValmartRESTfulAPI.Controllers
{
    [ApiController]
    [Route("products")]
    public class ProductController : ControllerBase
    {
         private readonly IProductRepository repo;

         public ProductController(IProductRepository repo)
         {
             this.repo = repo;
         }
         
         [HttpGet]
         public IEnumerable<ProductDTO> GetProducts()
         {
             var products = repo.getProducts().Select(product => product.AsDTO());
             return products;
         }
    }
}