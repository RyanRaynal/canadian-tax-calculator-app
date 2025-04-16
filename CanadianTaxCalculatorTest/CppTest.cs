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
        [Theory]
        [InlineData(19,35000,2082.5)]//Adult, regular input
        [InlineData(72,35000,0)]//Retired, overaged input
        public static void CppShouldReturnDoubleBasedOnAge(double age, double grossAmount,double expected)
        {
            //Arrange
            

            //Act
            double actual = Cpp.CppAmount(age, grossAmount);

            //Assert
            Assert.Equal(expected, actual);

        }
        
    }
}
    
