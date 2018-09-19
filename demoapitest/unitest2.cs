using System;
using demoapi;
using Xunit;

namespace demoapitest
{
    public class unitest2
    {
        [Fact]
        public void Test1()
        {
            var a = new MultiplicationtableLogic();
            var b = a.Multiplicationtable(3);
            Assert.Equal(9, b);
        }
        [Theory]
        [InlineData(2 ,6 )]
        [InlineData(1 , 3)]
        [InlineData(8, 24)]
        [InlineData(10 ,30)]

        public void test2(int number, int expecteted)
        {
            var a = new MultiplicationtableLogic();
            var b = a.Multiplicationtable(number);
            Assert.Equal(expecteted, b);

        }
    }
}