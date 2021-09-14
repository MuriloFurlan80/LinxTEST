using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SO.Domain.Entity;

namespace SO.Data.Mapping
{
    public class UserMapping : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("SO_USER");
            builder.HasKey(x => x.Id).HasName("ID");

            builder.Property(x => x.Name)
                .HasColumnName("NAME")
                .HasMaxLength(200)
                .IsRequired();

            builder.Property(x => x.Id)
                .HasColumnName("ID")
                .HasColumnType("varchar(255)")
                .IsRequired();
        }
    }
}
