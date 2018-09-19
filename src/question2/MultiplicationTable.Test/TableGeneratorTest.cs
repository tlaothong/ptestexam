using System;
using Xunit;

namespace MultiplicationTable.Test
{
    public class TableGeneratorTest
    {
        [Theory]
        [InlineData(3, new string[]{"*", "1", "2", "3", "1", "1", "2", "3", "2", "2", "4", "6", "3", "3", "6", "9"})]
        public void Test_Table_Generate(int inputNumber, string[] expected)
        {
            
        }
    }
}
