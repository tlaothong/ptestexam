using System;
using bmiapi;
using Xunit;

namespace bmitest
{
    public class UnitTest1
    {
        // [Fact]
        // public void Test1()
        // {
        //     var a = new calculatelogic();
        //     var result = a.bmi(150,50);
        //      Assert.Equal (22.2, result);
        // }


        [Theory]
        [InlineData (50, 150, 22)]
        [InlineData (70, 180, 21)]
        [InlineData (100, 180, 30)]
        [InlineData (40, 170, 13)]
        
       
        public void Test1 (double weight, double height, double expected) 
        {
            var a = new calculatelogic ();
            var b = a.bmi (weight, height);
            Assert.Equal (expected, b);
        }
    }
}




