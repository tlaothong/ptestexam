using System;
using api.Controllers;
using Xunit;

namespace api.tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(185, 85, 18.0)]
        [InlineData(165, 60, 32.22)]
        [InlineData(172, 71, 23.99)]
        public void TestBMICalculator(double weight, double height, double expected)
        {
            var Ctrl = new BMIController();
            var result = Ctrl.Calculator(weight, height);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(18.5)]
        [InlineData(20.22)]
        [InlineData(25)]
        public void BMINormalweightMessage(double bmi)
        {
            var expected = $"Your BMI: {bmi}/nYou're within the normal weight range.";
            var Ctrl = new BMIController();
            var result = Ctrl.BMIMessage(bmi);
            Assert.Equal(expected, result);
        }
        
        [Theory]
        [InlineData(18.4)]
        [InlineData(16.5)]
        public void BMIUnderweightMessage(double bmi)
        {
            var expected = "You're underweight. You should consult your doctor!";
            var Ctrl = new BMIController();
            var result = Ctrl.BMIMessage(bmi);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(25.1)]
        [InlineData(30.5)]
        public void BMIOverweightMessage(double bmi)
        {
            var expected = "You're overweight. You should consult your doctor!";
            var Ctrl = new BMIController();
            var result = Ctrl.BMIMessage(bmi);
            Assert.Equal(expected, result);
        }
    }
}
