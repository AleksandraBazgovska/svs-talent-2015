using Registar.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Registar.DomainModel;
using Registar.DataLayer;

namespace REgistar.Repository
{
    public class BikeRepository : IBikeRepository
    {
        public IList<Bike> SearchBikes()
        {
            using (var context = new RegistarDbContext())
            {
                

                var query = from b in context.Bikes
                            select b;
                             
               
                return query.ToList();
            }
        }
    }
}
