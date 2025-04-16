using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanadianTaxCalculator
{
    public static class InformationGathering
    {
        public static double AnnualSalary()
        {
            double annualSalary = 0;
            do
            {
                try
                {

                    Console.Write("What is the employee's annual salary?: ");
                    string annualSalaryText = Console.ReadLine();
                    annualSalary = double.Parse(annualSalaryText);
                    if (annualSalary < 1000)
                    {
                        DisplayMessages.ErrorMessageInvalidNumber();
                    }
                }
                catch(Exception)
                {
                    DisplayMessages.ErrorMessageInvalidNumericalValue();
                }
            }while (annualSalary < 1000);
            return annualSalary;
            
        }
        public static double Age()
        {
            double age = 0;
            do
            {
                try
                {
                    Console.Write("How old is the employee?: ");
                    string ageText = Console.ReadLine();
                    age = double.Parse(ageText);
                    if (age < 14)
                    {
                        Console.WriteLine("Please enter a valid age!");
                    }
                }
                catch (Exception)
                {
                    DisplayMessages.ErrorMessageInvalidNumericalValue();
                }

            } while (age < 14);
            return age;
        }
        public static string ProvinceOfEmployment()
        {
            string provinceOfEmployment = "";
            do
            {
                try
                {
                    Console.Write("What is the province of employment?: ");
                    provinceOfEmployment = Console.ReadLine();

                    if (provinceOfEmployment.ToLower() == "mauritius")
                    {
                        Console.WriteLine("Please enter a valid province!");
                    }
                }
                catch (Exception)
                {
                    DisplayMessages.ErrorMessageInvalidWord(); 
                }
            } while (provinceOfEmployment.ToLower() == "mauritius");
            return provinceOfEmployment;


        }
        public static double GrossAmount()
        {
            double grossAmount = 0;
            do
            {
                try
                {
                    Console.Write("Please enter the gross amount payable: ");
                    string grossAmountText = Console.ReadLine();
                    grossAmount = double.Parse(grossAmountText);

                    if (grossAmount < 10)
                    {
                        DisplayMessages.ErrorMessageInvalidNumber();
                    }
                }
                catch (Exception)
                {
                    DisplayMessages.ErrorMessageInvalidNumericalValue(); 
                }
            }while (grossAmount < 10);
            return grossAmount;
        }
        public static double NetAmount()
        {
            double netAmount = 0;
            do
            {
                try
                {
                    Console.Write("What is the net amount payable?: ");
                    string netAmountText = Console.ReadLine();
                    netAmount = double.Parse(netAmountText);

                    if (netAmount < 10)
                    {
                        DisplayMessages.ErrorMessageInvalidNumber(); 
                    }
                }
                catch(Exception)
                {
                    DisplayMessages.ErrorMessageInvalidNumericalValue();
                }
            } while (netAmount < 10);
            return netAmount;
        }
        public static string ContinueOrNot()
        {
            Console.WriteLine(" ");
            Console.Write("Do you wish to continue(Type Yes to Continue or No to Exit): ");
            string continueOrNot = Console.ReadLine();

            return continueOrNot;

        }
    }
}
