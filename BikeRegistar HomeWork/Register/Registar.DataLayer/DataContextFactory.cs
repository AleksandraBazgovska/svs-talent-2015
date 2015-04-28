using Registar.DataLayer.Interfaces;
using Reristar.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Registar.DataLayer
{
    public class DataContextFactory : IDataContextFactory
    {
        public TDataContext CreateDataContext<TDataContext>() where TDataContext : IDataContext
        {
                  
            if (typeof(TDataContext) == typeof(IRegistarContext))
            {
                return (TDataContext)(object) new RegistarDbContext();
            }
            return default(TDataContext);
        
    }
    }
}
