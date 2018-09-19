using System;
using Xunit;
using Services;

namespace Tests
{
    public class BmiTest
    {
        BMI svc;

        // [Theory(DisplayName = "BMI")]
        // [InlineData(120,172,"Obese 3")]
        // [InlineData(75,170,"Obese 2")]
        // [InlineData(55,165,"Normal weight")]
        // [InlineData(60,170,"Normal weight")]
        // public void checkbmi(int weight, int height, string expected)
        // {
        //      svc = new BMI();
        //      var result = svc.Resultbmi(weight,height);
        //      Assert.Equal(expected, result);
        // }

        [Theory(DisplayName = "BMI")]
        [InlineData(120, 172, "You are somewhat overweight.")]
        [InlineData(75, 170, "You are somewhat overweight.")]
        [InlineData(55, 165, "Congratulations! You are within a healthy weight range.")]
        [InlineData(65, 167, "Congratulations! You are within a healthy weight range.")]
        public void checkbmi(int weight, int height, string expected)
        {
            svc = new BMI();
            var result = svc.Resultbmi(weight, height);
            Assert.Equal(expected, result);
        }

    }
}
