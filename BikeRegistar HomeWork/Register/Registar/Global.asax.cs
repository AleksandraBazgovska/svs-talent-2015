using Registar.Common;
using Registar.DataLayer;
using Registar.Repository;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Registar
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AutofacConfig.ConfigureContainer();
            log4net.Config.XmlConfigurator.Configure(new FileInfo(Server.MapPath("~/Web.config")));
            InitProjects();
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }

        private void InitProjects()
        {
            //
            RepositoryManager.RegisterFactory(new DefaultRepositoryFactory());
            DataManagerContext.RegistarDataContextFactory(new DataContextFactory());
        }
    }
}
