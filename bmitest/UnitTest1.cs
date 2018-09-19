using System;
using Xunit;
using bmicalculate;

namespace bmitest
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(40, 155, 1.1704474505723206)]
        [InlineData(50, 158, 1.4080275596859477)]
        [InlineData(60, 160, 1.64765625)]
        [InlineData(75, 180, 1.6273148148148147)]
        [InlineData(80, 170, 1.9460207612456746)]
        [InlineData(90, 165, 2.3239669421487603)]
        [InlineData(72, 182,1.5280763192851106)]

        public void Test1(double weight, double hight, double expected)
        {
            var logic = new Logicbmi();
            var r = logic.BMI(weight, hight);
            Assert.Equal(expected, r);
        }
    }
}
