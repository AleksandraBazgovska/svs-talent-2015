using Registar.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Registar.DomainModel;
using Registar.DataLayer;
using Reristar.Common.Interfaces;
using Reristar.Common;
using Registar.DataLayer.Interfaces;
using System.Data.Linq;

namespace REgistar.Repository
{
    public class BikeRepository : IBikeRepository
    {
        ILogger logg = new LoggingExeptions();

        public IList<Bike> SearchBikes()
        {

            using (var context = DataManagerContext.CreateDataContext<IRegistarContext>()) {
                 var query = from b in context.Bikes
                            select b;
                //query = query.Where(p => p.Colour == "green");
                //if (query.ToList() == null)
                //{
                //    logg.LogError("There is no such record in database", new ApplicationException());
                //}

                return query.ToList();
            }



               



           
        }
    }
}
