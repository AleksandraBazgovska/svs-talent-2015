using Registar.BusinessLayer.Contracts;

namespace Registar.BusinessLayer.Tests
{
    public class BikeRegisterResult : CommandResult
    {
        public bool IsSuccess { get; internal set; }
    }
}