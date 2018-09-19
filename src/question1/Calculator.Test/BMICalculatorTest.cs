using System;
using Xunit;

namespace Calculator.Test
{
    public class BMICalculatorTest
    {
        [Theory]
        [InlineData(50, 40, 21.96875, "You're within the normal weight range.")]
        public void Test_Calculate_BMI(double weight, double height, string expectedBMI, string expectedMessage)
        {
            throw new NotImplementedException();
        }
    }
}
