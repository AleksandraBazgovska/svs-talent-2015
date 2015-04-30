using System;
using Registar.BusinessLayer.Handlers;

namespace Registar.BusinessLayer.Tests
{
    public class BikeRegisterCommandHandler: CommandHandlerBase<BikeRegisterCommand, BikeRegisterResult>
    {
        protected override BikeRegisterResult ExecuteCommand(BikeRegisterCommand command)
        {
            throw new NotImplementedException();

        }
    }
}