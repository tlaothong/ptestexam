using System;
using Xunit;
using Microsoft.AspNetCore.Mvc;
using bmicalculator.Controllers;

namespace bmicalculator.tests
{
    public class UnitTest1
    {
      ValuesController _controller = new ValuesController();
       
      
        [Theory]
        [InlineData(60,160,23.44,"You're within the normal weight range")]
        [InlineData(70,160,27.35,"You're overweight. You should consult your doctor!")]
        [InlineData(50,185,14.61,"You're underweight. You should consult your doctor!")]
        public void CalCulateBMI(double w,double h,double expected,string message)
        {
            var result = _controller.Calculate(w,h);
            Assert.Equal(expected,result.Bmi);
            Assert.Equal(message,result.Message);

        }
    }
}
