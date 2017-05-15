using Autofac;

namespace SkateCore.WebApi.Infrastructures
{
    public class AutofacConfig
    {
        public static ContainerBuilder Register()
        {
            var builder = new ContainerBuilder();

            builder.RegisterModule<DefaultModule>();

            return builder;
        }
    }
}
