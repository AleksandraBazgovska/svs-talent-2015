﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Registar.BusinessLayer.Handlers;
using Registar.BusinessLayer.Contracts;
using Registar.Repository.Interfaces;
using Registar.DomainModel;
using System.Collections.Generic;
using Registar.Common;
using Reristar.Common.Interfaces;

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
            RepositoryManager.RegisterFactory(new BikeRepoStubFactory());
            BikeSearchCommandHandler handler = new BikeSearchCommandHandler();
            BikeSearchCommand command = new BikeSearchCommand();
            
            //exercise
            BikeSearchResult result = handler.Execute(command) as BikeSearchResult;
            //verify
            Assert.IsNotNull(result, "SmokeTest expectes to return not null result!");
            //cleanup
            RepositoryManager.RegisterFactory(null);
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void ExecuteCommand_NullRepositoryFactory_ThrowsNullException_Test()
        {
            //setup
            RepositoryManager.RegisterFactory(null);
            BikeSearchCommandHandler handler = new BikeSearchCommandHandler();
            BikeSearchCommand command = new BikeSearchCommand();
            //exercise
            BikeSearchResult result = handler.Execute(command) as BikeSearchResult;
            //
            //Assert.IsNotNull(result);
        }


    }

    public class BikeRepoStub : IBikeRepository
    {
        public IList<Bike> SearchBikes()
        {
            List<Bike> result = new List<Bike>();
            return result;
        }

       
    }

    public class BikeRepoStubFactory : IRepositoryFactory
    {

        public TRepository CreateRepository<TRepository>() where TRepository : IRepository
        {
            BikeRepoStub result = new BikeRepoStub();
            return (TRepository)(object)result;
        }
    }






}

