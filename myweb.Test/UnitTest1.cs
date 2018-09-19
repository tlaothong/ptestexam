using System;
using Xunit;
using myweb.Api.Controllers;
using System.Collections.Generic;

namespace myweb.Test
{
    public class UnitTest1
    {
        [Theory(DisplayName = "คำนวณ BMI")]
        [InlineData(48, 158, 19.23)]
        [InlineData(20, 158, 8.01)]
        [InlineData(20, 188, 5.66)]
        public void QuestionITest(double weight, double height, double expectedValue)
        {
            var call = new PretestexamController();
            var result = call.QuestionI(weight, height);
            Assert.Equal(expectedValue, result);
        }

        [Theory(DisplayName = "ข้อสอง")]
        [InlineData(3,"0123\n1123\n2246\n3369\n")]
        [InlineData(2,"012\n112\n224\n")]
        [InlineData(4,"01234\n11234\n22468\n336912\n4481216\n")]
        public void QuestionIITest(int number, string expectedResult)
        {
            var call = new PretestexamController();
            var resultArray = call.QuestionII(number);
            Assert.Equal(expectedResult, resultArray);
        }

      

      
    }
}
