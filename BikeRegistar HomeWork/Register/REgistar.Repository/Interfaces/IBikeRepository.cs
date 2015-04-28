using Registar.DomainModel;
using Reristar.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registar.Repository.Interfaces
{
   public interface IBikeRepository : IRepository
    {
        //metod koj vrakja lista od prebaranite tocaci od baza
        IList<Bike> SearchBikes(); 
    }
}
