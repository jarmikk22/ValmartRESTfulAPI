namespace ValmartRESTfulAPI.Dtos
{
    public record CreateProductDTO
    {
        public string Name { get; init; }
        public string Brand { get; set; }
        public decimal Price { get; set; }
    }
}