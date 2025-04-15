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
        [Fact]
        public static void QpipShouldReturnDouble()
        {
            //Arrange
            double expected = 24.7;

            //Act
            double actual = Qpip.QpipAmount(5000);
            //Assert
            Assert.Equal(expected, actual);

        }
    }
}
