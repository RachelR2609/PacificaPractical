using Microsoft.EntityFrameworkCore;

namespace PacificaPractical.DBModels;

[PrimaryKey("Id")]
public partial class Seller : BaseDBModel
{
    public string? Name { get; set; }

    public bool? Enabled { get; set; }

    public int? DisplayOrder { get; set; }

    public List<Product> Products { get; set; }
}
