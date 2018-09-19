using System;
using System.Linq;
using Xunit;
using FluentAssertions;

namespace multiplication.tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(1, 2)]
        public void Test1(int number, int expectedRows)
        {
            var sut = new MultiplicationLogic();
            var actual = sut.GetMultiplicationTable(number);
            Assert.Equal(expectedRows, actual.Rows.Count());
        }
    }
}
