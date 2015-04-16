using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SOLID_LSP.Good_example;

namespace SOLID_LSP
{
    class Program
    {
      public static void Main(string[] args)
        {
            Area_VolumeAcalculator calculator = new Area_VolumeAcalculator();

            List<IVolumeShape> VolumeShapes = new List<IVolumeShape>();

            VolumeShapes.Add(new Cuboid(12, 2, 4));
            VolumeShapes.Add(new Sphere(4));
            /* VolumeShapes.Add(new Rectangle(2, 3));  dokolku sakame da go postavime i Rectangle kako del od listata VolumeShapes,
            ke ni javi gresha zatoa sto vednash prepoznava deka Rectangle go nema implementirano interfejsot IVolumeShapes
          
            */

            Console.WriteLine("Volumenot na telata od listata VolumeShapes iznesuva {0} ", calculator.Volume(VolumeShapes.ToArray()));
            Console.ReadKey();


            // 
        }
    }
}
