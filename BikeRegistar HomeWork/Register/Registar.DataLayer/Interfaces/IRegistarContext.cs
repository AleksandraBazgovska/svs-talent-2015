using Registar.DomainModel;
using Reristar.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registar.DataLayer.Interfaces
{
  public interface IRegistarContext : IDataContext,IDisposable
    {
       DbSet<Bike> Bikes { get; set; }
    }
}
