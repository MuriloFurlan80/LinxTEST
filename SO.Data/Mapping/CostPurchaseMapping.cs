using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SO.Domain.Entity;
using System;

namespace SO.Data.Mapping
{
    public class CostPurchaseMapping : IEntityTypeConfiguration<CostPurchase>
    {
        public void Configure(EntityTypeBuilder<CostPurchase> builder)
        {
            builder.ToTable("SO_COST_PURCHASE");
            builder.HasKey(x => x.Id).HasName("ID");

            builder.Property(x => x.Value)
                .HasColumnName("VALUE")
                .HasColumnType("decimal(10,5)")
                .HasDefaultValue(default(decimal));

            builder.Property(x => x.ProductId)
                .HasColumnName("PRODUCT_ID")
                .HasColumnType("varchar(255)")
                .IsRequired();

            builder.Property(x => x.Id)
                .HasColumnName("ID")
                .HasColumnType("varchar(255)")
                .IsRequired();

            builder.HasOne(x => x.Product)
                .WithOne(x => x.CostPurchase)
                .HasForeignKey<CostPurchase>(x => x.ProductId)
                .IsRequired();
        }
    }
}
