using Registar.Common;
using Registar.Repository;
using System;
using System.Collections.Generic;
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

            InitProjects();
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }

        private void InitProjects()
        {
            //
            RepositoryManager.RegisterFactory(new DefaultRepositoryFactory());
        }
    }
}
