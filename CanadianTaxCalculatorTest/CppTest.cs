using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CanadianTaxCalculator;

namespace CanadianTaxCalculatorTest
{
    public static class CppTest
    {
        [Fact]
        public static void CppRegularShouldReturnDouble()
        {
            //Arrange
            double expectedRegular = 2082.5;

            //Act
            double actualRegular = Cpp.CppAmount(19, 35000);

            //Assert
            Assert.Equal(expectedRegular, actualRegular);

        }
        [Fact]
        public static void CppRetiredShouldReturnDouble()
        {
            //Arrange
            double expectedRetired = 0;

            //Act
            double actualRetired = Cpp.CppAmount(72, 35000);

            //Assert
            Assert.Equal(expectedRetired, actualRetired);

        }
    }
}
    
