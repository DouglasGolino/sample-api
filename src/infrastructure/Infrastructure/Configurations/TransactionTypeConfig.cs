using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations
{
    public class TransactionTypeConfig : IEntityTypeConfiguration<TransactionType>
    {
        public void Configure(EntityTypeBuilder<TransactionType> builder)
        {
            builder.Property(t => t.CreatedAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP");

            builder.ToTable(t =>
            {
                t.HasCheckConstraint("CK_Type_Name", "Name IN ('Expense', 'Income')");
            });
        }
    }
}