using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_LSP.Bad_example
{
   public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public override double Area()
        {
            return Width * Height;
        }

        public override double Volume()
        {
            throw new NotImplementedException();
        }

        public Rectangle(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }
    }
}
