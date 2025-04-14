using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanadianTaxCalculator
{
    public static class Qpip
    {
        public static double QpipAmount(double grossAmount)
        {
            double qpip = ((0.494/100)*grossAmount);
            qpip = (double)Math.Round(qpip,2);
            return qpip;

        }
    }
}
