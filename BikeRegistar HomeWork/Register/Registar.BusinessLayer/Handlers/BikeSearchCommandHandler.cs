using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Registar.BusinessLayer.Contracts;
using Registar.DataLayer;
using Registar.DomainModel;

namespace Registar.BusinessLayer.Handlers
{
    internal class BikeSearchCommandHandler:CommandHandlerBase<BikeSearchCommand,BikeSearchResult>
    {
        protected override BikeSearchResult ExecuteCommand(BikeSearchCommand command)
        {
            using (RegistarDbContext context = new RegistarDbContext())
            {
                //IEnumerable<Bike> bikes = new List<Bike>();
                //bikes = context.Bikes
                //        .OrderBy(p => p.BikeId)
                //        .Take(10);
                        //.ToList();

                var query = from b in context.Bikes
                            select b;
                if (!string.IsNullOrEmpty(command.Colour))
                {
                    query = query.Where(x => x.Colour == command.Colour); // gi prebaruva tocacite po boja 
                }
                if (!string.IsNullOrEmpty(command.Producer))
                {
                    query = query.Where(x => x.Producer == command.Producer); // gi prebaruva po proizvoditel
                }

                //query = query
                //        .OrderBy(x => x.BikeId)
                //        .Skip(command.PageIndex*command.PageSize)
                //        .Take(command.PageSize);
                ////

                BikeSearchResult result = new BikeSearchResult();
                result.Result = query.ToList();
                return result;
            }
            
        }
    }
}
