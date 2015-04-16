using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_LSP.Bad_example
{
    public class Cuboid : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public double Length { get; set; }

        public Cuboid(double width, double height, double length)
        {
            Width = width;
            Height = height;
            Length = length;
        }

        public override double Area()
        {
            return 2*(Width * Height + Height * Length + Width * Length);
        }

        public override double Volume()
        {
            return Width * Height * Length;
        }
    }
}
