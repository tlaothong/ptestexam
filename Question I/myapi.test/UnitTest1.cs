using System;
using Xunit;
using myapi.Controllers;
namespace myapi.test
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(150,72, "Your BMI : 20.3")]
        [InlineData(155,72, "Your BMI : 21.0")]
        [InlineData(155,84, "You're within the normal weight range.")]
        [InlineData(190,84, "Your BMI : 18.9")]
        public void Test1(double weight, double height, string expected)
        {
            var engine = new BMIEngine();
            var bmi = engine.GetBMI(weight, height);
            Assert.Equal(expected, bmi);
        }
    }
}
