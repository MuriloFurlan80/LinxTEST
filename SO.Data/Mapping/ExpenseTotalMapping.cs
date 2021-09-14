using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SO.Domain.Entity;

namespace SO.Data.Mapping
{
    public class ExpenseTotalMapping : IEntityTypeConfiguration<ExpenseTotal>
    {
        public void Configure(EntityTypeBuilder<ExpenseTotal> builder)
        {
            builder.ToTable("SO_EXPENSE_TOTAL");
            builder.HasKey(x => x.Id).HasName("ID");

            builder.HasOne(x => x.Store)
                .WithOne(x => x.ExpenseTotal)
                .HasForeignKey<ExpenseTotal>(x => x.StoreId);

            builder.Property(x => x.Value)
                .HasColumnName("VALUE")
                .HasColumnType("decimal(10,5)")
                .HasDefaultValue(default(decimal));

            builder.Property(x => x.StoreId)
                .HasColumnName("STORE_ID")
                .HasColumnType("varchar(255)")
                .IsRequired();

            builder.Property(x => x.Id)
                .HasColumnName("ID")
                .HasColumnType("varchar(255)")
                .IsRequired();
        }
    }
}
