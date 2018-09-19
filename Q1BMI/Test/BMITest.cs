using Xunit;
using System;
using BMIService;
namespace Test
{
    public class UBMITest 
    {
        BMI svc;
        
        [Theory]
        [InlineData(26, "You're overweight. You should consult your doctor")]
        [InlineData(12, "You're underweight. You should consult your doctor")]
        [InlineData(20, "You're within the normal weight range")]
        public void TestBMI(double bmi, string expected)
        {
            svc = new BMI();
            var result = svc.GetResult(bmi);
            Assert.Equal(expected, result);
        }
        
    }
}