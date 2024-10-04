using Microsoft.EntityFrameworkCore;
using PacificaPractical.DBModels;

namespace PacificaPractical.Database;

public partial class ProductDbContext : DbContext
{
    public DbSet<Product> Products { get; set; }

    public DbSet<Seller> Sellers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Data Source=PINGURACH;Initial Catalog=ProductDB; Persist Security Info=True; Integrated Security=SSPI; Trust Server Certificate=True");

    //protected override void OnModelCreating(ModelBuilder modelBuilder)
    //{
    //    modelBuilder.Entity<Product>(entity =>
    //    {
    //        entity.ToTable("Product");

    //        entity.Property(e => e.Name).HasMaxLength(50);

    //        entity.HasOne(d => d.Seller).WithMany(p => p.Products)
    //            .HasForeignKey(d => d.SellerId)
    //            .HasConstraintName("FK_Product_Seller");
    //    });

    //    modelBuilder.Entity<Seller>(entity =>
    //    {
    //        entity.ToTable("Seller");

    //        entity.Property(e => e.Enabled).HasDefaultValue(true);
    //        entity.Property(e => e.Name)
    //            .HasMaxLength(50)
    //            .IsUnicode(false);
    //    });

    //    OnModelCreatingPartial(modelBuilder);
    //}

    //partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
