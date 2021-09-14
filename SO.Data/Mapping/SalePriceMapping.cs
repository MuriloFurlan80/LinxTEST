using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SO.Domain.Entity;

namespace SO.Data.Mapping
{
    public class SalePriceMapping : IEntityTypeConfiguration<SalePrice>
    {
        public void Configure(EntityTypeBuilder<SalePrice> builder)
        {
            builder.ToTable("SO_SALE_PRICE");
            builder.HasKey(x => x.Id).HasName("ID");
            
            builder.HasOne(x => x.Product)
                .WithOne(x => x.SalePrice)
                .HasForeignKey<SalePrice>(x => x.ProductId);

            builder.Property(x => x.ProfitMargin)
                .HasColumnName("PROFIT_MARGIN")
                .HasColumnType("decimal(10,5)")
                .HasDefaultValue(default(decimal));

            builder.Property(x => x.Value)
                .HasColumnName("VALUE")
                .HasColumnType("decimal(10,5)")
                .IsRequired();

            builder.Property(x => x.ProductId)
                .HasColumnName("PRODUCT_ID")
                .HasColumnType("varchar(255)")
                .IsRequired();

            builder.Property(x => x.Id)
                .HasColumnName("ID")
                .HasColumnType("varchar(255)")
                .IsRequired();

        }
    }
}
