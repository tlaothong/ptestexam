using System;
using bmiapi.Controllers;
using Xunit;

namespace bmiapi.tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(143, 68, 21.7, true)] // normal
        [InlineData(176, 68, 26.8, null)] // over
        [InlineData(88, 68, 13.4, false)] // under
        public void CheckBMINormalCases(double weight, double height, double expectedBMI, bool? isNormal)
        {
            var sut = new BMIController();
            var actual = sut.Get((int)weight, (int)height);
            Assert.Equal(expectedBMI, actual.BMI);

            if (isNormal == true) Assert.Equal("You're within the normal weight range.", actual.Message);
            else if (isNormal == false) Assert.Equal("You're underweight. You should consult your doctor!", actual.Message);
            else Assert.Equal("You're overweight. You should consult your doctor!", actual.Message);
        }

        [Theory]
        [InlineData(0, 68)]
        [InlineData(-1, 68)]
        [InlineData(176, 0)]
        [InlineData(176, -14)]
        public void CheckBMIExceptionCases(double weight, double height)
        {
            var sut = new BMIController();
            var actual = sut.Get((int)weight, (int)height);
            Assert.Null(actual);
        }
    }
}
