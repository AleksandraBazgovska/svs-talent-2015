using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgrammingBasics.Classes.Common
{
    public struct InterestRate
    {
        public decimal Percent;
        public UnitOfTime Unit;

        public InterestRate(decimal percent, UnitOfTime unit)
        {
            this.Percent = percent;
            this.Unit = unit;
        }
    }
}
