using Autofac;
using Registar.Repository.Interfaces;
using REgistar.Repository;
using Reristar.Common.Interfaces;

namespace Registar.Common
{
    /// <summary>
    /// DataModule e odgovorna za registriranje na zavisnosti koi se definirani vo proektot
    /// </summary>
    public class DataModule : Module
    {
        private string connStr;
        public DataModule(string connString)
        {
            this.connStr = connString;
        }
        protected override void Load(ContainerBuilder builder)
        {


            builder.RegisterType<BikeRepository>().As<IBikeRepository>().InstancePerRequest();

            base.Load(builder);
        }
    }
}