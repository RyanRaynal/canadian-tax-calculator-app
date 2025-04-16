using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CanadianTaxCalculator;

namespace CanadianTaxCalculatorTest
{
    public static class FederalTaxTest
    {
        [Theory]
        [InlineData (50000,5000,750)]//First rate should return 15% of gross amount
        [InlineData (75000, 5000, 1025)]//Second rate should return 20.5% of gross amount
        [InlineData (150000, 5000, 1300)]//Third rate should return 26% of gross amount
        [InlineData (200000, 5000, 1450)]//Fourth rate should return 29% of gross amount
        [InlineData (275000, 5000, 1650)]//Fifth rate should return 33% of gross amount
        public static void FederalTaxAllRatesShouldReturnDouble(double annualSalary, double grossAmount, double expected)
        {
            //Arrange
           
            //Act
            double actual =  FederalTax.FederalTaxAmount(annualSalary, grossAmount);

            //Assert
            Assert.Equal(expected, actual);
        }
        


    }
}
