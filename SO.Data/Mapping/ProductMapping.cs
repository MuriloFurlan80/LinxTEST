using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SO.Domain.Entity;

namespace SO.Data.Mapping
{
    public class ProductMapping : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("SO_PRODUCT");

            builder.HasKey(x => x.Id).HasName("ID");
            builder.Property(x => x.Name)
                .HasColumnName("NAME")
                .HasColumnType("varchar(50)")
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(x => x.Price)
                .HasColumnName("PRICE")
                .HasColumnType("decimal(10,5)")
                .HasDefaultValue(default(decimal))
                .IsRequired();

            builder.Property(x => x.Quantity)
                .HasColumnName("QUANTITY")
                .HasColumnType("int")
                .IsRequired();

            builder.Property(x => x.Description)
                .HasColumnName("DESCRIPTION")
                .HasColumnType("varchar(200)")
                .HasMaxLength(200)
                .IsRequired();

            builder.Property(x => x.StoreId)
                .HasColumnName("STORE_ID")
                .HasColumnType("varchar(255)")
                .IsRequired();

            builder.Property(x => x.Id)
                .HasColumnName("ID")
                .HasColumnType("varchar(255)")
                .IsRequired();

            builder.HasOne(x => x.Store)
                .WithMany(x => x.Products)
                .HasForeignKey(x => x.StoreId)
                .IsRequired();

            builder.HasOne(x => x.Photo)
                .WithOne(x => x.Product)
                .IsRequired();

            builder.HasOne(x => x.CostPurchase)
               .WithOne(x => x.Product)
               .IsRequired();
        }
    }
}
