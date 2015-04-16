using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_LSP.Good_example
{
   public class Cuboid : IAreaShape, IVolumeShape
    {
        public double Width { get; set; } // shirina
        public double Height { get; set; } // visina 
        public double Length { get; set; } //dolzina

        public Cuboid(double width, double height, double length)
        {
            Width = width;
            Height = height;
            Length = length;
        }

        public double Area()
        {
            return 2 * (Width * Height + Height * Length + Width * Length);
        }

        public double Volume()
        {
            return Width * Height * Length;

        }
    }
}
