using System;
using System.Collections.Generic;
using Somsor.Q2.MultiplicationTable.Engines;
using Xunit;

namespace Somsor.Q2.MultiplicationTable.Test
{
    public class UnitTest1
    {
        public static IEnumerable<object[]> GenerateMultiplicationTableTestScenarios =>
            new List<object[]>
            {
                new object[] { 3, new List<List<int>> { new List<int> { 1, 2, 3 }, new List<int> { 2, 4, 6 }, new List<int> { 3, 6, 9 } } },
                new object[] { 5, new List<List<int>> { new List<int> { 1, 2, 3, 4, 5 }, new List<int> { 2, 4, 6, 8, 10 }, new List<int> { 3, 6, 9, 12, 15 }, new List<int> { 4, 8, 12, 16, 20 }, new List<int> { 5, 10, 15, 20, 25 } } },
            };
        [Theory]
        [MemberData(nameof(GenerateMultiplicationTableTestScenarios))]
        public void GenerateMultiplicationTableTest(int number, List<List<int>> expected)
        {
            var engine = new MultiplicationTableEngine();
            var result = engine.GenerateMultiplicationTable(number);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(3, new int[] { 1, 2, 3 })]
        [InlineData(5, new int[] { 1, 2, 3, 4, 5 })]
        [InlineData(7, new int[] { 1, 2, 3, 4, 5, 6, 7 })]
        [InlineData(10, new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 })]
        public void GenerateNumberTest(int number, int[] expected)
        {
            var engine = new MultiplicationTableEngine();
            var result = engine.GenerateNumber(number);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(1, 2, 2 )]
        [InlineData(1000, 3, 3000 )]
        [InlineData(215, 8, 1720 )]
        public void MultiplyNumberTest(int n1, int n2, int expected)
        {
            var engine = new MultiplicationTableEngine();
            var result = engine.MultiplyNumber(n1, n2);
            Assert.Equal(expected, result);
        }
    }
}
