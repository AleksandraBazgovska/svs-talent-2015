using Autofac;
using Autofac.Integration.Mvc;
using Registar.Common;
using Registar.Repository;


namespace Registar
{
    public class AutofacConfig
    {
        public static void ConfigureContainer()
        {
            var builder = new ContainerBuilder();

            // Register dependencies in controllers
            builder.RegisterControllers(typeof(MvcApplication).Assembly);


            // Register our Data dependencies
            builder.RegisterModule(new DataModule("RegistarDbContext"));
        }
    }
}