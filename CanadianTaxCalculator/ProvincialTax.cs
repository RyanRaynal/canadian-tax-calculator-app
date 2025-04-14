using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CanadianTaxCalculator
{
    public static class ProvincialTax
    {
        public static double ProvincialTaxAmount(double annualSalary, double grossAmount)
        {

            double provincialTax = 0;
            if (annualSalary <= 53255)
            {
                provincialTax = ((double)(14.0 / 100) * grossAmount);
                provincialTax = (double)Math.Round(provincialTax, 2);
            }
            else if (annualSalary > 53255 && annualSalary <= 106495)
            {
                provincialTax = ((double)(19.0 / 100) * grossAmount);
                provincialTax = (double)Math.Round(provincialTax, 2);
            }
            else if (annualSalary > 106495 && annualSalary <= 129590)
            {
                provincialTax = ((double)(24.0 / 100) * grossAmount);
                provincialTax = (double)Math.Round(provincialTax, 2);
            }
            else if (annualSalary > 129590)
            {
                provincialTax = ((double)(25.75 / 100) * grossAmount);
                provincialTax = (double)Math.Round(provincialTax, 2);
            }
            return provincialTax;
        
        }


        

    }
}
