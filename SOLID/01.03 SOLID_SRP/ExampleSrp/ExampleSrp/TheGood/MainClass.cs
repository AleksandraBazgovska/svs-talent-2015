using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleSrp.TheGood
{
    class MainClass
    {
        static void Main(string[] args)
        {
            //TODO Proverka na programata 

            ILogger loger = new Cloud();
            ILoggerComputer compLogger = new PhoneLog();
            AcmeCar car = new AcmeCar(loger, compLogger);

            car.Lock();


        }
    }
}
