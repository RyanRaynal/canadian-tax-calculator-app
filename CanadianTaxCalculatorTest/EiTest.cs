using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CanadianTaxCalculator;

namespace CanadianTaxCalculatorTest
{
    public static class EiTest
    {
        [Fact]
        public static void EiAdultShouldReturnDouble()
        {
            //Arrange
            double expectedAdult = 574;


            //Act
            double actualAdult = Ei.EiAmount(19,35000);

            //Assert
            Assert.Equal(expectedAdult, actualAdult);

            
        }
        [Fact]
        public static void EiMinorShouldReturnDouble()
        {
            //Arrange
            double expectedMinor = 0;


            //Act
            double actualMinor = Ei.EiAmount(16, 35000);

            //Assert
            Assert.Equal(expectedMinor, actualMinor);


        }
    }
}
