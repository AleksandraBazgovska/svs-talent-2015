using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_OPEN_CLOSE_PRINCIPE.Bad_Example
{
  public class AreaCalculator // Klasa koj presmetuva ploshtina 
    {
        public double Area(object[] shapes)
        {
            double area = 0;

            foreach (object item in shapes)
            {
                if(item is Rectangle)
                {
                    Rectangle rect = (Rectangle)item;
                    area += (rect.Width * rect.Height);
                }

                else
                {
                    Circle circle = (Circle)item;
                    area += (circle.Radius * circle.Radius) * Math.PI;
                }
            }

            return area;
        }
    }
}
