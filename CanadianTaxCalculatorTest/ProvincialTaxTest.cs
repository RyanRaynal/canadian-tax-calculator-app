using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CanadianTaxCalculator;

namespace CanadianTaxCalculatorTest
{
    public static class ProvincialTaxTest
    {
        [Theory]
        [InlineData (50000,5000,700)]//First rate should return 14% of the gross amount
        [InlineData (75000, 5000, 950)]//Second rate should return 19% of the gross amount
        [InlineData (115000, 5000, 1200)]//Third rate should return 24% of the gross amount
        [InlineData (140000, 5000, 1287.5)]//Fourth rate should return 25.75% of the gross amount

        public static void ProvincialTaxAllRatesShouldReturnDouble(double annualSalary, double grossAmount, double expected)
        {
            //Arrange

            //Act
            double actual = ProvincialTax.ProvincialTaxAmount(annualSalary, grossAmount);

            //Assert
            Assert.Equal(expected, actual);

        }
        
    }
}
