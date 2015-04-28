using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Registar.BusinessLayer.Contracts;

using Registar.DomainModel;
using Registar.Common;
using Reristar.Common.Interfaces;
using Registar.Repository.Interfaces;

namespace Registar.BusinessLayer.Handlers
{
    public class BikeSearchCommandHandler:CommandHandlerBase<BikeSearchCommand,BikeSearchResult>
    {

        protected override BikeSearchResult ExecuteCommand(BikeSearchCommand command)
        {
            IBikeRepository repo = RepositoryManager.CreateRepository<IBikeRepository>(); //RepositoryManager kreira repository od tip IBikeRepository

            BikeSearchResult result = new BikeSearchResult();
            result.Result = repo.SearchBikes() as List<Bike>;
            // //
            return result;          

        }
    }
}
