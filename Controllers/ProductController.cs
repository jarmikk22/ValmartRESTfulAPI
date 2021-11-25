using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
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
         public IEnumerable<Product> GetProducts()
         {
             return repo.getProducts();
         }
    }
}