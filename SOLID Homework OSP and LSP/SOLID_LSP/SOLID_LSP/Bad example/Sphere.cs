using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_LSP.Bad_example
{
   public class Sphere : Shape
    {
        public double Radius { get; set; }

        public Sphere(double radius)
        {
            Radius = radius; 
        }

        public override double Area()
        {
            return 4 * Math.PI * Math.Pow(Radius, 2);
        }

        public override double Volume()
        {
            return (4 / 3) * Math.PI * Math.Pow(Radius, 3);
        }
    }
}
