using System;
using Xunit;

namespace Calculator.Test
{
    public class BMICalculatorTest
    {
        [Theory]
        [InlineData(50, 40, 21.96875, "You're within the normal weight range.")]
        [InlineData(40, 40, 17.575, "You're underweight. You should consult your doctor!")]
        [InlineData(0, 40, 0, "Can't calculate please try again")]
        [InlineData(40, 0, 0, "Can't calculate please try again")]
        [InlineData(0, 0, 0, "Can't calculate please try again")]
        public void Test_Calculate_BMI(double weight, double height, double expectedBMI, string expectedMessage)
        {
            var cal = new BMICalculator();
            var result = cal.Calculate(weight, height);
            
            Assert.Equal(expectedBMI, result.BMI);
            Assert.Equal(expectedMessage, result.SuggestMessage);
        }
    }
}
