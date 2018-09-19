using System;
using Xunit;
using myLibrary;
using FluentAssertions;

namespace myTest
{
    public class MultiplicationTableTest
    {
        [Theory]
        [InlineData(1, new string[] { "* 1", "1 1" })]
        [InlineData(2, new string[] { "* 1 2", "1 1 2", "2 2 4" })]
        [InlineData(3, new string[] { "* 1 2 3", "1 1 2 3", "2 2 4 6", "3 3 6 9" })]
        [InlineData(4, new string[] { "* 1 2 3 4", "1 1 2 3 4", "2 2 4 6 8", "3 3 6 9 12", "4 4 8 12 16" })]
        public void MultiplicationTable_Successed(int amount, string[] expected)
        {
            var cal = new MultiplicationTable();
            var result = cal.Calculate(amount);
            result.Should().BeEquivalentTo(expected);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        public void MultiplicationTable_Failed(int amount)
        {
            var cal = new MultiplicationTable();
            var result = cal.Calculate(amount);
            Assert.Null(result);
        }
    }
}
