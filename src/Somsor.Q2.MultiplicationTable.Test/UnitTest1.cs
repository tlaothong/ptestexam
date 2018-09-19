using System;
using Somsor.Q2.MultiplicationTable.Engines;
using Xunit;

namespace Somsor.Q2.MultiplicationTable.Test
{
    public class UnitTest1
    {
        [Theory]
        // [InlineData()]
        public void GenerateMultiplicationTableTest()
        {

        }
        
        [Theory]
        [InlineData(3, new int[] { 1, 2, 3 })]
        public void GenerateNumberTest(int number, int[] expected)
        {
            var engine = new MultiplicationTableEngine();
            var result = engine.GenerateNumber(number);
            Assert.Equal(expected, result);
        }
    }
}
