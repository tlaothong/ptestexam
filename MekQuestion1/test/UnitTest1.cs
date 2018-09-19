using System;
using Xunit;
using api.Controllers;

namespace test
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(60,180,13.01)]
        public void Bmitest(double weight, double height, double expected)
        {
            var cal = new ValuesController();
            var r = cal.Bmirun(weight, height);
            Assert.Equal(expected, r);
        }
    }
}
