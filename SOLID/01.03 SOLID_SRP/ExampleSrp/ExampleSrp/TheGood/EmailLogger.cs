using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleSrp.TheGood
{
    public class EmailLogger : ILogger
    {
        public void Lock()
        {
            Console.WriteLine("Error locking the car send via email");
        }

        public void LogException(string exception)
        {
            Console.WriteLine(exception);
        }

        public void Unlock()
        {
            Console.WriteLine("Error unlocking the car send via email");
        }
    }
}
