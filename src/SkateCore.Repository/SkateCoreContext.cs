using Microsoft.EntityFrameworkCore;
using SkateCore.Repository.Extensions;
using System.Reflection;

namespace SkateCore.Repository
{
    public class SkateCoreContext : DbContext
    {
        private const string AppSchema = "app";

        public SkateCoreContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema(AppSchema);

            modelBuilder.AddEntityConfigurationsFromAssembly(Assembly.Load(new AssemblyName("SkateCore.Repository")));

            base.OnModelCreating(modelBuilder);
        }
    }
}
