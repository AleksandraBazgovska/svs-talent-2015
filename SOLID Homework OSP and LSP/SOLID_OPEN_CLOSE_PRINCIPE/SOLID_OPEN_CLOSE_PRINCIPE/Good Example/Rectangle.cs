using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_OPEN_CLOSE_PRINCIPE.Good_Example
{
    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public override double Area()
        {
            return Width * Height;
        }

        public Rectangle(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }
    }
}
