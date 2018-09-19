using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;
using FluentAssertions;

namespace multiplication.tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(1, "* 1", "1 1")]
        [InlineData(3, "* 1 2 3", "1 1 2 3", "2 2 4 6", "3 3 6 9")]
        public void InputCorrectNumber(int number, params string[] expectedRows)
        {
            var sut = new MultiplicationLogic();
            var actual = sut.GetMultiplicationTable(number);
            Assert.NotNull(actual);
            var actualRows = actual.Rows.ToArray();
            Assert.Equal(expectedRows.Count(), actualRows.Count());
            for (int index = 0; index < expectedRows.Count(); index++)
            {
                Assert.Equal(expectedRows[index], actualRows[index]);
            }
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        [InlineData(-3)]
        public void InputIncorrectNumber(int number)
        {
            var sut = new MultiplicationLogic();
            var actual = sut.GetMultiplicationTable(number);
            Assert.NotNull(actual);
            var actualRows = actual.Rows.ToArray();
            Assert.False(actual.Rows.Any());
        }

        [Theory]
        [InlineData(1, "* 1")]
        [InlineData(5, "* 1 2 3 4 5")]
        [InlineData(10, "* 1 2 3 4 5 6 7 8 9 10")]
        public void CheckFirstFow(int number, string expected)
        {
            var sut = new MultiplicationLogic();
            var firstFow = sut.GenerateFirstRow(number);
            Assert.Equal(expected, firstFow);
        }
    }
}
