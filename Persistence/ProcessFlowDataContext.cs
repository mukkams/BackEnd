using Domain.Models.ProcessFlow;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class ProcessFlowDataContext : DbContext
    {
        public ProcessFlowDataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<PFProcessType> PFProcessTypes { get; set; }

        public DbSet<PFActivity> PFActivities { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            {
                // Use the entity name instead of the Context.DbSet<T> name
                // refs https://docs.microsoft.com/en-us/ef/core/modeling/relational/tables#conventions
                modelBuilder.Entity(entityType.ClrType).ToTable(entityType.ClrType.Name);
            }
        }
    }
}
