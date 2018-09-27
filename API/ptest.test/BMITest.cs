using FluentAssertions;
using System;
using Xunit;

namespace ptest.test
{
    public class BMITest
    {
        [Theory(DisplayName = " คำนวน BMI ได้ถูกต้อง")]
        [InlineData(84, 160, 2.30671875, "You're underweight. You should consult your doctor!")]
        [InlineData(840, 160, 23.0671875, "You're within the normal weight range.")]
        [InlineData(3500, 170, 85.13840830449827, "You're overweight. You should consult your doctor!")]

        public void BMITestSuccess(double weight, double height, double expectedBMI,string expectedMessage)
        {
            var cal = new ptestapi.Q1();

            var result = cal.BmiCal(weight,height);

            result.BMI.Should().Be(expectedBMI);
            result.Message.Should().Be(expectedMessage);
        }
    }
}
