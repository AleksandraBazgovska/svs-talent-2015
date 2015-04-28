using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Registar.BusinessLayer.Handlers;
using Registar.BusinessLayer.Contracts;
using Registar.Repository.Interfaces;
using Registar.DomainModel;
using System.Collections.Generic;

namespace Registar.BusinessLayer.Tests
{
    [TestClass]
    public class TesBikeSearchCommandHandlerTests
    {
        /// <summary>
        /// Prvo metodata koja sakam da ja testirame, (Ime na komandata, Ime na testot, Ocekuvan rezultat)
        /// </summary>
        [TestMethod]
        public void ExecuteCommand_SmokeTest_NoException_Test()
        {
            //setup

            BikeSearchCommandHandler handler = new BikeSearchCommandHandler();
            BikeSearchCommand command = new BikeSearchCommand();
            
           
            //exercies
            BikeSearchResult result = handler.Execute(command);
            //verify
            Assert.IsNotNull(result, "Smoke test expects not null result");
            //teardown
        }

        public class BikeRepoStub : IBikeRepository
        {
            public IList<Bike> SearchBikes()
            {
                throw new NotImplementedException();
            }

            
        }


       
    }
}
