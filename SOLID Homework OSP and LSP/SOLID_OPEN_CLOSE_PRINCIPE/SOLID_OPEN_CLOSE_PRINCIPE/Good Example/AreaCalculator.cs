using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_OPEN_CLOSE_PRINCIPE.Good_Example
{
   public class AreaCalculator
    {
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
