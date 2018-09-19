using System;
using Xunit;
using demoapi;

namespace demoapitest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var a = new CalculatorLogic();
            var b = a.Calculator(20,174);
            Assert.Equal(194,b);

        }
        [Theory]
        [InlineData(3,174,177)]
        public void test2 (double weight,double high,double expecteted)
        {
             var a = new CalculatorLogic();
            var b = a.Calculator(weight,high);
            Assert.Equal(expecteted,b);

        }
    }
}
