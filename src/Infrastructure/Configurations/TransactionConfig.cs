using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations
{
    public class TransactionConfig : IEntityTypeConfiguration<Transaction>
    {
        public void Configure(EntityTypeBuilder<Transaction> builder)
        {
            builder.Property(t => t.CreatedAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP");
        }
    }
}