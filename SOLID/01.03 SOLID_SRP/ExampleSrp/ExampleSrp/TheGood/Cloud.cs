using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleSrp.TheGood
{
  public class Cloud : ILogger
    {     

        public void Unlock()
        {
            Console.WriteLine("There was an error unlocking the car!");
        }

        public void Lock()
        {
            Console.WriteLine("There was an error locking the car!");
        }

        public void LogException(string exception)
        {
            Console.WriteLine(exception);
        }
    }
}
