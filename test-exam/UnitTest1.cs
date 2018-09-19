using System;
using Xunit;
using webapi_exam.Controllers;

namespace test_exam
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(176 , 65 , 29.3)]
        [InlineData(180 , 68 , 27.4)]
        [InlineData(165 , 69 , 24.4)]
        public void bmitest(double weight, double height, double expected){
            var b = new ValuesController();
            var x = b.calculatingbmi(weight , height);
            Assert.Equal(expected , x);
        }
    }
}
