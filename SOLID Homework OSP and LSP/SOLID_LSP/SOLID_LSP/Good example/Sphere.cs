using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_LSP.Good_example
{
   public class Sphere : IAreaShape, IVolumeShape
    {
        public double Radius { get; set; }

        public Sphere(double radius)
        {
            Radius = radius;
        }

        public double Area()
        {
            return 4 * Math.PI * Math.Pow(Radius, 2);
        }

        public double Volume()
        {
            return (4 / 3) * Math.PI * Math.Pow(Radius, 3);
        }
    }
}
