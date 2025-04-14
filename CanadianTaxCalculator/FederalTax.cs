using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanadianTaxCalculator
{
    public static class FederalTax
    {
        public static double FederalTaxAmount(double annualSalary, double grossAmount)
        {

            double federalTax = 0;
            if (annualSalary <= 57375)
            {
                federalTax = ((double)(15.0 / 100) * grossAmount);
                federalTax = (double)Math.Round(federalTax,2);
            }
            else if (annualSalary > 57375 && annualSalary <= 114750)
            {
                federalTax = ((double)(20.5 / 100) * grossAmount);
                federalTax = (double)Math.Round(federalTax, 2);
            }
            else if (annualSalary > 114750 && annualSalary <= 177882)
            {
                federalTax = ((double)(26.0 / 100) * grossAmount);
                federalTax = (double)Math.Round(federalTax, 2);
            }
            else if (annualSalary > 177882 && annualSalary <= 253414)
            {
                federalTax = ((double)(29.0 / 100) * grossAmount);
                federalTax = (double)Math.Round(federalTax, 2);
            }
            else if (annualSalary > 253414)
            {
                federalTax = ((double)(33.0/100) * grossAmount);
                federalTax = (double)Math.Round(federalTax, 2);
            }
            return federalTax;

           
            
            
            
        }
    }
}
