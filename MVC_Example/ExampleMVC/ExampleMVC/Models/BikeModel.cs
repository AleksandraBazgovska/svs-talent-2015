using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExampleMVC.Models
{
    public class BikeModel
    {
        public string RegNumber { get; set; }
        public string Producer { get; set; }
        public string Model { get; set; }
        public string Colour { get; set; }


        public BikeModel(string regnumber, string producer, string model, string colour)
        {
            this.RegNumber = regnumber;
            this.Producer = producer;
            this.Model = model;
            this.Colour = colour;
        }
    }
}