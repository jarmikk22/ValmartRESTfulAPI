using System;

namespace ValmartRESTfulAPI.Entities
{
    public record Product
    {
        public Guid Id { get; set; }
        public string Name { get; init; }
        public string Brand { get; set; }
        public decimal Price { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}