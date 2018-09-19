using System;
using Xunit;
using webapi;

namespace demomobileapp
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(50, 170, "14.7")]
        [InlineData(80, 180, "22.2")]
        [InlineData(66, 198, "16.7")]
        [InlineData(66, 230, "14.3")]
        [InlineData(130, 160, "50.8")]

        public void Calculator(double weight, double height, string expected)
        {
            var c = new CalBmi();
            var bmi = c.Calculator(weight, height);


            try
            {
                string bmifinal = bmi.ToString("#,###.0");
                Assert.Equal(expected, bmifinal);
            }
            catch (Exception ex)
            {
                Assert.Equal("Normal people can't have height than 220 and weight than 120", ex.Message.ToString());
                 
            }
        }

        
    }
}
