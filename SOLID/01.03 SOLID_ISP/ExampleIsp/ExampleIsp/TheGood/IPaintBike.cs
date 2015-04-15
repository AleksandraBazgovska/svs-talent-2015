using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleIsp.TheGood
{
   public interface IPaintBike
    {
        /// <summary>
        /// Paints the bike
        /// </summary>
        /// <param name="paintColour"></param>
        /// <returns></returns>
        int PaintBike(int paintColour);
    }
}
