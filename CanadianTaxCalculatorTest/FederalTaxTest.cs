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
        [Fact]
        public static void FederalTaxFirstRateShouldReturnDouble()
        {
            //Arrange
            double expectedFirstRate = 750;
            

            //Act
            double actualFirstRate =  FederalTax.FederalTaxAmount(50000, 5000);

            //Assert
            Assert.Equal(expectedFirstRate, actualFirstRate);
        }
        [Fact]
        public static void FederalTaxSecondRateShouldReturnDouble()
        {
            //Arrange
            double expectedSecondRate = 1025;


            //Act
            double actualSecondRate = FederalTax.FederalTaxAmount(75000, 5000);

            //Assert
            Assert.Equal(expectedSecondRate, actualSecondRate);
        }
        [Fact]
        public static void FederalTaxThirdRateShouldReturnDouble()
        {
            //Arrange
            double expectedThirdRate = 1300;


            //Act
            double actualThirdRate = FederalTax.FederalTaxAmount(150000, 5000);

            //Assert
            Assert.Equal(expectedThirdRate, actualThirdRate);
        }
        [Fact]
        public static void FederalTaxFourthRateShouldReturnDouble()
        {
            //Arrange
            double expectedFourthRate = 1450;


            //Act
            double actualFourthRate = FederalTax.FederalTaxAmount(200000, 5000);

            //Assert
            Assert.Equal(expectedFourthRate, actualFourthRate);
        }
        [Fact]
        public static void FederalTaxFifthRateShouldReturnDouble()
        {
            //Arrange
            double expectedFifthRate = 1650;


            //Act
            double actualFifthRate = FederalTax.FederalTaxAmount(275000, 5000);

            //Assert
            Assert.Equal(expectedFifthRate, actualFifthRate);
        }


    }
}
