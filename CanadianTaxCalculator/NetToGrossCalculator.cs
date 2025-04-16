using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanadianTaxCalculator
{
    public static class NetToGrossCalculator
    {
        public static double CppCalculation(double age)
        { 
            double cppCalculation = 0;
            if (age >= 70)
            {
                cppCalculation = 0;
            }
            else if (age < 70)
            {
                cppCalculation = ((double)5.95 / 100);
            }
            return cppCalculation;
        }
        public static double EiCalculation(double age)
        {
            double eiCalculation = 0;
            if (age < 18)
            {
                eiCalculation = 0;
            }
            else if (age >= 18)
            {
                eiCalculation = ((double)1.64 / 100);
            }
            return eiCalculation;
        
        }
        public static double FederalTaxCalculation(double annualSalary)
        {
            double federalTaxCalculation = 0;

            if (annualSalary <= 57375)
            {
                federalTaxCalculation = ((double)(15.0 / 100));
                
            }
            else if (annualSalary > 57375 && annualSalary <= 114750)
            {
                federalTaxCalculation = ((double)(20.5 / 100));
            }
            else if (annualSalary > 114750 && annualSalary <= 177882)
            {
                federalTaxCalculation = ((double)(26.0 / 100));
            }
            else if (annualSalary > 177882 && annualSalary <= 253414)
            {
                federalTaxCalculation = ((double)(29.0 / 100));
                
            }
            else if (annualSalary > 253414)
            {
                federalTaxCalculation = ((double)(33.0 / 100));
                
            }
            return federalTaxCalculation;

        }
        public static double ProvincialTaxCalculation(double annualSalary)
        {
            double provincialTaxCalculation = 0;

            if (annualSalary <= 53255)
            {
                provincialTaxCalculation = ((double)(14.0 / 100));
            }
            else if (annualSalary > 53255 && annualSalary <= 106495)
            {
                provincialTaxCalculation = ((double)(19.0 / 100));
            }
            else if (annualSalary > 106495 && annualSalary <= 129590)
            {
                provincialTaxCalculation = ((double)(24.0 / 100));
                
            }
            else if (annualSalary > 129590)
            {
                provincialTaxCalculation = ((double)(25.75 / 100));
            }
            return provincialTaxCalculation;

        }
        public static double Qpip()
        {
            double qpip = ((double)(0.494 / 100));
            return qpip;
        }
        public static double NetToGrossOutsideQuebec(double age, double annualSalary, double netAmount)
        {
            double cppCalculation = NetToGrossCalculator.CppCalculation(age);
            double eiCalculation = NetToGrossCalculator.EiCalculation(age);
            double federalTaxCalculation = NetToGrossCalculator.FederalTaxCalculation(annualSalary);

            double netToGrossCalculation = ((double)(netAmount/(1 - (cppCalculation +  eiCalculation + federalTaxCalculation))));
            netToGrossCalculation = (double)Math.Round(netToGrossCalculation,2);

            return netToGrossCalculation;

        }
        public static double NetToGrossQuebec(double age, double annualSalary,double netAmount)
        {
            double cppCalculation = NetToGrossCalculator.CppCalculation(age);
            double eiCalculation = NetToGrossCalculator.EiCalculation(age);
            double federalTaxCalculation = NetToGrossCalculator.FederalTaxCalculation(annualSalary);
            double provincialTaxCalculation = NetToGrossCalculator.ProvincialTaxCalculation(annualSalary);
            double qpipCalculation = NetToGrossCalculator.Qpip();

            double netToGrossCalculation = ((double)(netAmount/(1-(cppCalculation + eiCalculation + federalTaxCalculation + provincialTaxCalculation + qpipCalculation))));
            netToGrossCalculation = (double)Math.Round(netToGrossCalculation ,2);
            return netToGrossCalculation;

        }

    }
}
