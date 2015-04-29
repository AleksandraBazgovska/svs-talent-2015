using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Registar.DomainModel;

namespace Registar.BusinessLayer.Tests
{
    [TestClass]
    public class BikeRegisterCommandHandlerUnitTests
    {
        [TestMethod]
        public void ExecuteCommand_NotExistingOwnerId()
        {
            //setup
           
            //BikeRegisterCommandHandler handler = new BikeRegisterCommandHandler();
            //BikeRegistarCommand command = new BikeRegistarCommand();
            //command.BikeToRegister = new Bike();

            ////not valid owner ids are negative numbers
            //command.BikeToRegister.BikeOwnerId = int.MinValue;
            ////exercise
            //BikeRegistarResult result = handler.Execute(command) as BikeRegistarResult;
            ////verify
            //Assert.IsFalse(result.IsSuccess, "For not valid ");
            //StringAssert.Contains(result.ValidationError[0], "not vaid ownerid", "For not valid owner id");
            ////cleanup
        }
    }
}
