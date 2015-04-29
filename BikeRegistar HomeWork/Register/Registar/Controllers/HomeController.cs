using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Registar.BusinessLayer;
using Registar.BusinessLayer.Contracts;
using Registar.Models;
using Registar.DomainModel;
using Reristar.Common.Interfaces;

namespace Registar.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        readonly log4net.ILog logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        //private IRepository repo;
        //public HomeController()
        //{
        //    this.repo = repo;
        //}

        public ActionResult Index()
        {
            logger.Info("Now you can see the results from database");
            //call BL
            BikeSearchCommand _command = new BikeSearchCommand();
            BikeSearchResult _result = CommandInvoker.InvokeCommand<BikeSearchCommand, BikeSearchResult>(_command);
            //

            //Dokolku IRepository imashe metod SearchBikes,i toj da bide implementiran od IBikeRepository 
            //var bikes = repo.SearchBikes().ToList();
            return View(_result.Result);
        }

       
        [HttpGet]
        public ActionResult GetSearchResult()
        {
            BikeSearchCommand _command = new BikeSearchCommand();
            BikeSearchResult _result = CommandInvoker.InvokeCommand<BikeSearchCommand, BikeSearchResult>(_command);

            return Json(_result.Result, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Index2()
        {
            List<BikeModel> _result = new List<BikeModel>();
            _result.Add(new BikeModel() { Colour = "red", Model = "R1", Producer = "Specialized", RegNumber = "007" });
            _result.Add(new BikeModel() { Colour = "red", Model = "R1", Producer = "Specialized", RegNumber = "007" });
            _result.Add(new BikeModel() { Colour = "red", Model = "R1", Producer = "Specialized", RegNumber = "007" });
            _result.Add(new BikeModel() { Colour = "red", Model = "R1", Producer = "Specialized", RegNumber = "007" });
            //
            this.ViewBag.SomeNewProperty = "theValue";
            this.ViewData["SomeNewProperty"] = "theValue";
            //
            return View("Index",_result);
        }

        public ActionResult Test()
        {
            return View();
        }

    }
}
