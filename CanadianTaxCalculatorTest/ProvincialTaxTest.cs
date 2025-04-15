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
        [Fact]
        public static void ProvincialTaxFirstRateShouldReturnDouble()
        {
            //Arrange
            double expectedFirstRate = 700;

            //Act
            double actualFirstRate = ProvincialTax.ProvincialTaxAmount(50000, 5000);

            //Assert
            Assert.Equal(expectedFirstRate, actualFirstRate);

        }
        [Fact]
        public static void ProvincialTaxSecondRateShouldReturnDouble()
        {
            //Arrange
            double expectedSecondRate = 950;

            //Act
            double actualSecondRate = ProvincialTax.ProvincialTaxAmount(75000, 5000);

            //Assert
            Assert.Equal(expectedSecondRate, actualSecondRate);

        }
        [Fact]
        public static void ProvincialTaxThirdRateShouldReturnDouble()
        {
            //Arrange
            double expectedThirdRate = 1200;

            //Act
            double actualThirdRate = ProvincialTax.ProvincialTaxAmount(115000, 5000);

            //Assert
            Assert.Equal(expectedThirdRate, actualThirdRate);

        }
        [Fact]
        public static void ProvincialTaxFourthRateShouldReturnDouble()
        {
            //Arrange
            double expectedFourthRate = 1287.5 ;

            //Act
            double actualFourthRate = ProvincialTax.ProvincialTaxAmount(140000, 5000);

            //Assert
            Assert.Equal(expectedFourthRate, actualFourthRate);

        }
    }
}
