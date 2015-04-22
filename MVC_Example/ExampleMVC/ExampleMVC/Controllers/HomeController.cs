using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ExampleMVC.Models;

namespace ExampleMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            List<BikeModel> bikes = new List<BikeModel>();
            bikes.Add(new BikeModel("001", "Producer1", "BMX", "blue"));
            bikes.Add(new BikeModel("002", "Producer2", "BMX", "blue"));

            bikes.Add(new BikeModel("003", "Producer3", "BMX", "blue"));

            bikes.Add(new BikeModel("004", "Producer4", "BMX", "blue"));

            return View(bikes);
        }
    }
}