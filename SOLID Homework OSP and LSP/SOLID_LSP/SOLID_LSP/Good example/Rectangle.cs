using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_LSP.Good_example
{
   public class Rectangle : IAreaShape  // Rectangel implementira samo IAreaShape zatoa sto ima samo ploshtina
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Area()
        {
            return Width * Height;
        }
    }
}
