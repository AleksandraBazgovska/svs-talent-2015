using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleSrp.TheGood
{
  public interface ILogger
    {
        void Unlock();
        void Lock();

        void LogException(string exception);
    }
}
