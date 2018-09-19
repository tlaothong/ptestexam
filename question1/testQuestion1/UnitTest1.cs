using System;
using Xunit;
using question1API.Controllers;
using question1API.Models;

namespace testQuestion1
{
    public class UnitTest1
    {
        [Theory(DisplayName = "cal()")]
        [InlineData(157,60,24.34175828634022)]
        [InlineData(165,50,18.36547291092746)]
        [InlineData(170,70,24.22145328719723)]
        [InlineData(180,71,21.91358024691358)]

        public void Test1(double weight, double height,double expected)
        {
            var calBMI = new CalController();
            var y = calBMI.calculate(height,weight);
            Assert.Equal(expected,y.bmi);
        }
    }
}

