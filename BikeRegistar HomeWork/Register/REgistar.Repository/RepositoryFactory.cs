using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reristar.Common.Interfaces;
using REgistar.Repository;
using Registar.Repository.Interfaces;

namespace Registar.Repository
{
    public class DefaultRepositoryFactory : IRepositoryFactory
    {
        public TRepository CreateRepository<TRepository>() where TRepository : IRepository
        {
            if (typeof(TRepository) == typeof(IBikeRepository))
            {
                return (TRepository)(object)new BikeRepository();
            }
            return default(TRepository);
        }
    }
}
