using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SO.Domain.Entity;
using System;

namespace SO.Data.Mapping
{
    public class PhotoMapping : IEntityTypeConfiguration<Photo>
    {
        public void Configure(EntityTypeBuilder<Photo> builder)
        {
            builder.ToTable("SO_PHOTO");
            builder.HasKey(x => x.Id).HasName("ID");

            builder.Property(x => x.Image)
                .HasColumnName("IMAGE")
                .HasColumnType("blob")
                .IsRequired();

            builder.Property(x => x.ProductId)
                .HasColumnName("PRODUCT_ID")
                .HasColumnType("varchar(255)")
                .IsRequired();

            builder.Property(x => x.Id)
                .HasColumnName("ID")
                .HasColumnType("varchar(255)")
                .IsRequired();

            builder.HasOne(x => x.Product)
                .WithOne(x => x.Photo)
                .HasForeignKey<Photo>(x => x.ProductId);
        }
    }
}
