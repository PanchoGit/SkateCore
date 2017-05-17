using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using SkateCore.Domain;

namespace SkateCore.Data.Entity
{
    public class SkateCoreContext : DbContext
    {
        public SkateCoreContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Skater> Skaters { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("app");

            foreach (var entity in modelBuilder.Model.GetEntityTypes())
            {
                entity.Relational().TableName = entity.DisplayName();
            }

            base.OnModelCreating(modelBuilder);
        }
    }
}
