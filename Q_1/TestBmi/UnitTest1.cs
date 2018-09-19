using System;
using Xunit;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using BmiApi.Controllers;

namespace TestBmi
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(74, 178, 23.355636914530994)]
        [InlineData(90, 178, 28.40550435551067)]
        [InlineData(60, 159, 23.73323840037973)]
        [InlineData(40, 145, 19.024970273483948)]
        public void Test1(double weight, double height, double expected)
        {
            var bmiModel = new BmiController();
            var bmiV = bmiModel.calculateBMI(weight, height);

            Assert.Equal(expected, bmiV.bmi);

        }
    }
}
