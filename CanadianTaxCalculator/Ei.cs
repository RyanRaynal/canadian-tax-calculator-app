using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanadianTaxCalculator
{
    public static class Ei
    {
        public static double EiAmount(double age,double grossAmount)
        {
            double ei = 0;

            if (age >= 18)
            {
                ei = ((double)(1.64 / 100) * grossAmount);
                ei = (double)Math.Round(ei, 2);
            }
            else if (age < 18)
            {
                ei = 0;
            }
                return ei;  
        }
    }
}
