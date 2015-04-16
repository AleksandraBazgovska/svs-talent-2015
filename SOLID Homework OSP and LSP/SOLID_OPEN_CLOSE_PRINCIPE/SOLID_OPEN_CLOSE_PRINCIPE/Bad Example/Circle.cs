using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_OPEN_CLOSE_PRINCIPE.Bad_Example
{
  public class Circle
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            this.Radius = radius;
        }
    }
}
