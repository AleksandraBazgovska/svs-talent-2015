using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SOLID_OPEN_CLOSE_PRINCIPE.Good_Example;

namespace SOLID_OPEN_CLOSE_PRINCIPE
{
    class Program
    {
        static void Main(string[] args)
        {
            AreaCalculator calc = new AreaCalculator();
            Shape[] shapes = new Shape[4];
            shapes[0] = new Rectangle(12, 5);
            shapes[1] = new Rectangle(2, 4);
            shapes[2] = new Circle(12);
            shapes[3] = new Circle(5);

            Console.WriteLine("Area of all shapes in the array is {0} ", calc.Area(shapes));
            Console.ReadKey();
        }
    }
}
