using CanadianTaxCalculator;

int choice = GrossOrNetChoice.GrossOrNetChoiceAnswer();

if (choice == 1)
{

    double annualSalary = InformationGathering.AnnualSalary();
    double age = InformationGathering.Age();
    string provinceOfEmployment = InformationGathering.ProvinceOfEmployment();
    double grossAmount = InformationGathering.GrossAmount();

    Console.WriteLine(" ");
    Console.WriteLine($"Gross Amount = ${grossAmount}");

    double cppOutput = Cpp.CppAmount(age, grossAmount);
    Console.WriteLine($"CPP = ${cppOutput}");

    double eiOutput = Ei.EiAmount(age, grossAmount);
    Console.WriteLine($"EI = ${eiOutput}");

    double federalTax = FederalTax.FederalTaxAmount(annualSalary, grossAmount);
    Console.WriteLine($"Federal Tax = ${federalTax}");

    if (provinceOfEmployment.ToLower() == "quebec")
    {
        double provincialTax = ProvincialTax.ProvincialTaxAmount(annualSalary, grossAmount);
        Console.WriteLine($"Provincial Tax = ${provincialTax}");

        double qpip = Qpip.QpipAmount(grossAmount);
        Console.WriteLine($"QPIP = ${qpip}");

        double netAmount = grossAmount - (cppOutput + eiOutput + federalTax + provincialTax + qpip);
        netAmount = (double)Math.Round(netAmount, 2);
        Console.WriteLine($"Net Amount = ${netAmount}");
    }
    else
    {
        double netAmount = grossAmount - (cppOutput + eiOutput + federalTax);
        netAmount = (double)Math.Round(netAmount, 2);
        Console.WriteLine($"Net Amount = ${netAmount}");
    }
}
else if (choice == 2)
{
    double netAmount = InformationGathering.NetAmount();

    double annualSalary = InformationGathering.AnnualSalary();
    double age = InformationGathering.Age();
    string provinceOfEmployment = InformationGathering.ProvinceOfEmployment();

    if (provinceOfEmployment.ToLower() != "quebec")
    {
        double output = NetToGrossCalculator.NetToGrossOutsideQuebec(age, annualSalary, netAmount);
        Console.WriteLine($"Gross Amouunt = ${output}");
    }
    else if (provinceOfEmployment.ToLower() == "quebec")
    {
       double output = NetToGrossCalculator.NetToGrossQuebec(age,annualSalary, netAmount);
        Console.WriteLine($"Gross Amount = ${output}");
    }

}
DisplayMessages.GoodbyeMessage();




