using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_LSP.Good_example
{
   public class Area_VolumeAcalculator
    {
        public double Area(IAreaShape[] shapes)
        {
            double area = 0;

            foreach (IAreaShape item in shapes)
            {
                area += item.Area();
            }

            return area;
        }

        public double Volume(IVolumeShape[] shapes)
        {
            double volume = 0;

            foreach (IVolumeShape item in shapes)
            {
                volume += item.Volume();

            }

            return volume;
        }
    }
}
