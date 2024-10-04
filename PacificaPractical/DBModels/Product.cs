using Microsoft.EntityFrameworkCore;

namespace PacificaPractical.DBModels;

[PrimaryKey("Id")]
public partial class Product : BaseDBModel
{
    public string? Name { get; set; }

    public bool? Enabled { get; set; }

    public int? DisplayOrder { get; set; }

    public int? SellerId { get; set; }

    public virtual Seller? Seller { get; set; }
}
