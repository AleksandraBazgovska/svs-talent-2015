using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgrammingBasics.Classes.Common
{
    public struct TimePeriod
    {
        public int Period;
        public UnitOfTime Unit;

        public TimePeriod(int period, UnitOfTime Unit)
        {
            this.Period = period;
            this.Unit = Unit;
        }
    }
}
