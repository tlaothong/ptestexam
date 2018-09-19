using System;
using Xunit;
using bmicalculate;

namespace bmitest
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(60, 160, 1.64765625)]
        public void Test1(double weight, double hight, double expected)
        {
            var logic = new Logicbmi();
            var r = logic.BMI(weight, hight);
            Assert.Equal(expected, r);
        }
    }
}
