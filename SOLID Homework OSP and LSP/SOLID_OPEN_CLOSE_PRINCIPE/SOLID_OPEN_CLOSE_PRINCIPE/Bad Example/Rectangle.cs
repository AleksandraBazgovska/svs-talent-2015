using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_OPEN_CLOSE_PRINCIPE.Bad_Example
{
   public class Rectangle
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }
    }
}
