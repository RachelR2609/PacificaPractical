namespace PacificaPractical.DTOs
{
    public class SellerDTO
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public bool? Enabled { get; set; }

        public int? DisplayOrder { get; set; }

        public List<ProductDTO> Products { get; set; }
    }
}
