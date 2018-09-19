using System;
using Xunit;

namespace api.tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(68, 165, )]
        public void HaveNormalWeight(double weight, double height, string expected)
        {
            var Ctrl = new BMIController();
            var result = Ctrl.Calculator(weight, height);
            Assert.Equal(expected, result)
        }
    }
}
