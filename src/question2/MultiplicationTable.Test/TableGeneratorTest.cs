using System;
using Xunit;

namespace MultiplicationTable.Test
{
    public class TableGeneratorTest
    {
        [Theory]
        [InlineData(0, new string[]{"*", "\n"})]
        [InlineData(1, new string[]{"*", "1", "\n", "1", "1", "\n"})]
        [InlineData(3, new string[]{"*", "1", "2", "3", "\n", "1", "1", "2", "3", "\n", "2", "2", "4", "6", "\n", "3", "3", "6", "9", "\n"})]
        public void Test_Table_Generate(int inputNumber, string[] expected)
        {
            var tableGenerator = new TableGenerator();
            var result = tableGenerator.Generate(inputNumber);
            Assert.Equal(expected, result);
        }
    }
}
