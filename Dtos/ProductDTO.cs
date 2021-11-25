using System;

namespace ValmartRESTfulAPI.Dtos
{
    public record ProductDTO
    {
        public Guid Id { get; set; }
        public string Name { get; init; }
        public string Brand { get; set; }
        public decimal Price { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}