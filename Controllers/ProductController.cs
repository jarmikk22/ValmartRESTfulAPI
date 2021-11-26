using System;
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
             var products = repo.GetProducts().Select(product => product.AsDTO());
             return products;
         }

         [HttpPost]
         public ActionResult<ProductDTO> CreateProduct(CreateProductDTO productDto)
         {
             var product = new Product()
             {
                 Id = Guid.NewGuid(),
                 Name = productDto.Name,
                 Brand = productDto.Brand,
                 Price = productDto.Price,
                 CreatedDate = new DateTime(),
             };
             repo.CreateProduct(product);
             return Ok(product.AsDTO());
         }
    }
}