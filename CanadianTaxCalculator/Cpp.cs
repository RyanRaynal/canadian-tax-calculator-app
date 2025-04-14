using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanadianTaxCalculator
{
    public static class Cpp
    {
        public static double CppAmount(double age,double grossAmount)
        {
            double cpp = 0;
            if (age < 70)
            {
                cpp = ((5.95 / 100) * grossAmount);
                cpp = (double)Math.Round(cpp, 2);
            }
            else if (age >= 70)
            {
                cpp = 0;
            }
            return cpp;
        }
    }
}
