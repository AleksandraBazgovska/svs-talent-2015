using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_LSP.Bad_example
{
   public class Area_VolumeCalculator
    {
        /// <summary>
        /// Ova pretstavuva losh primer zatoa shto site objekti koi se od tip Shape se pretpostavuva deka go imaat implementirano 
        /// metodot Volume(), a vo konkretniov sluchaj programata ke frli exeption zatoa shto Rectangle koj e isto taka Shape nema 
        /// implementacija na metodot Volume
        /// </summary>
        /// <param name="shapes"></param>
        /// <returns></returns>
        public double Volume(Shape[] shapes)
        {
            double volume = 0;
            foreach (Shape item in shapes)
            {
                volume += item.Volume();

            }

            return volume;
            
        }

        public double Area(Shape[] shapes)
        {
            double area = 0;

            foreach (Shape item in shapes)
            {
                area += item.Area();

            }

            return area;
        }
    }
}
