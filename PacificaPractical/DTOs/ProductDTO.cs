using PacificaPractical.DBModels;

namespace PacificaPractical.DTOs
{
    public class ProductDTO
    {
        public string? Name { get; set; }

        public bool? Enabled { get; set; }

        public int? DisplayOrder { get; set; }

        public int? SellerId { get; set; }

        public virtual Seller? Seller { get; set; }

        public ProductDTO()
        {

        }
    }
}
