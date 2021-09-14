using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SO.Domain.Entity;
using System;

namespace SO.Data.Mapping
{
    public class StoreMapping : IEntityTypeConfiguration<Store>
    {
        public void Configure(EntityTypeBuilder<Store> builder)
        {
            builder.ToTable("SO_STORE");
            builder.HasKey(x => x.Id).HasName("ID");

            builder.Property(x => x.Name)
                .HasColumnName("NAME")
                .HasMaxLength(200)
                .IsRequired();

            builder.Property(x => x.Id)
                .HasColumnName("ID")
                .HasColumnType("varchar(255)")
                .IsRequired();

            builder.HasMany(x => x.Products)
                .WithOne(x => x.Store)
                .HasForeignKey(x => x.StoreId);
        }
    }
}
