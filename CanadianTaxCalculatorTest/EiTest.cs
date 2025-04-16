using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using CanadianTaxCalculator;

namespace CanadianTaxCalculatorTest
{
    public static class EiTest
    {
        [Theory]
        [InlineData(19,35000,574)]//Adult age input
        [InlineData(16,35000,0)]//Minor age input
        public static void EiShouldReturnDoubleBasedOnAge(double age, double grossAmount, double expected)
        {
            //Arrange

            //Act
            double actualAdult = Ei.EiAmount(age, grossAmount);

            //Assert
            Assert.Equal(expected, actualAdult);   
        }
       
    }
}
