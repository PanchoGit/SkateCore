using Microsoft.EntityFrameworkCore;
using EntityFrameworkCore.MappingExtension;
using SkateCore.Repository.Maps;
using System.Reflection;
using System.Linq;
using System;

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

            modelBuilder.AddMapping(new SkaterMap());

            //var typesToRegister = Assembly.Load(new AssemblyName("SkateCore.Repository")).GetTypes()
            //.Where(type => !String.IsNullOrEmpty(type.Namespace))
            //.Where(type => type.GetTypeInfo().BaseType != null && type.GetTypeInfo().BaseType.GetTypeInfo().IsGenericType && type.GetTypeInfo().BaseType.GetGenericTypeDefinition() == typeof(ModelTypeConfiguration<>));
            //foreach (var type in typesToRegister)
            //{
            //    dynamic configurationInstance = Activator.CreateInstance(type);
            //    //modelBuilder.AddMapping<type.GetTypeInfo()>(configurationInstance);
            //}

            base.OnModelCreating(modelBuilder);
        }
    }
}
