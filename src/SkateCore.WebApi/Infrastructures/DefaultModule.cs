using Autofac;
using System.Linq;
using SkateCore.WebApi.Helpers;

namespace SkateCore.WebApi.Infrastructures
{
    public class DefaultModule : Module
    {
        private const string DataAssemblyEndName = "Data";
        private const string WorkflowAssemblyEndName = "Workflow";

        protected override void Load(ContainerBuilder builder)
        {
            var assemblies = AssemblyHelper.GetReferencingAssemblies("SkateCore").ToArray();

            builder.RegisterAssemblyTypes(assemblies)
                .Where(s => s.Name.EndsWith(WorkflowAssemblyEndName))
                .AsImplementedInterfaces();

            builder.RegisterAssemblyTypes(assemblies)
                .Where(s => s.Name.EndsWith(DataAssemblyEndName))
                .AsImplementedInterfaces();
        }
    }
}
