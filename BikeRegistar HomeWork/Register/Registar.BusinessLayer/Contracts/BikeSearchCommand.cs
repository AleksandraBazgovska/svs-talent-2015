using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registar.BusinessLayer.Contracts
{
    public class BikeSearchCommand:Command
    {
        public string Producer { get; set; }

        public string Colour { get; set; }

        public string RegNumber { get; set; }


        //public BikeSearchCommand(string producer, string colour, string regNumber)
        //{
        //    this.Colour = colour;
        //    this.Producer = producer;
        //    this.RegNumber = regNumber;
        //}

        //public int PageSize { get; set; }

        //public int PageIndex { get; set; }

    }
}
