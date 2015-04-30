using Registar.BusinessLayer.Contracts;
using Registar.DomainModel;

namespace Registar.BusinessLayer.Tests
{
    public class BikeRegisterCommand : Command
    {
        public Bike BikeToRegister;
    }
}