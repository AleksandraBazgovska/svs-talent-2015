using Reristar.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registar.DataLayer
{
   public static class DataManagerContext
    {
        private static IDataContextFactory theFactory;

        public static TDataContext CreateDataContext<TDataContext>() where TDataContext : IDataContext
        {
            TDataContext result = theFactory.CreateDataContext<TDataContext>();
            return result;
        }

        public static void RegistarDataContextFactory(IDataContextFactory factory)
        {
            theFactory = factory;
        }

    }
}
