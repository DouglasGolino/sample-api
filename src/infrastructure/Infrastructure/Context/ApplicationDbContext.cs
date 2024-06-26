using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Infrastructure.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
            ChangeTracker.AutoDetectChangesEnabled = false;
            ChangeTracker.LazyLoadingEnabled = false;
        }

        public DbSet<Category> Categories { get; set; }

        public DbSet<TransactionType> TransactionTypes { get; set; }

        public DbSet<Transaction> Transactions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=my_host;Database=my_db;Username=my_user;Password=my_pw");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);

            var entityTypes = modelBuilder.Model.GetEntityTypes();
            foreach (var entityType in entityTypes)
            {
                foreach (var foreignKey in entityType.GetForeignKeys())
                {
                    foreignKey.DeleteBehavior = DeleteBehavior.ClientSetNull;
                }
            }

            base.OnModelCreating(modelBuilder);
        }
    }
}