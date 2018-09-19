using System;
using Xunit;
using myLibrary;
using FluentAssertions;

namespace myTest
{
    public class MultiplicationTableTest
    {
        [Fact]
        public void MultiplicationTable_Successed()
        {
            var cal = new MultiplicationTable();
            var result = cal.Calculate(3);

            var expected = new string[,] { { "*", "1", "2", "3" }, { "1", "1", "2", "3" }, { "2", "2", "4", "6" }, { "3", "3", "6", "9" } };
            result.Should().BeEquivalentTo(expected);

        }
    }
}
