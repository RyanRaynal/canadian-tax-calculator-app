using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CanadianTaxCalculator;

namespace CanadianTaxCalculatorTest
{
    public static class QpipTest
    {
        [Theory]
        [InlineData (5000,24.7)]//Should return 0.494% of the gross amount
        public static void QpipShouldReturnDouble(double grossAmount, double expected)
        {
            //Arrange

            //Act
            double actual = Qpip.QpipAmount(grossAmount);
            //Assert
            Assert.Equal(expected, actual);

        }
    }
}
