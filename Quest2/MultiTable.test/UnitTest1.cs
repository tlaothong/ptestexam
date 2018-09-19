using System;
using Xunit;
using MultiTable;

namespace MultiTable.test
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(2, "*\t1\t2")]
        [InlineData(7, "*\t1\t2\t3\t4\t5\t6\t7")]
        public void GetHeaderOfTable(int input, string expected)
        {
            var Ctrl = new Multiplication();
            var result = Ctrl.getHeader(input);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(2, 2, "2\t2\t4")]
        [InlineData(3, 7,"3\t3\t6\t9\t12\t15\t18\t21")]
        public void GetRowOfTable(int rowNUmber, int input, string expected)
        {
            var Ctrl = new Multiplication();
            var result = Ctrl.getRow(rowNUmber, input);
            Assert.Equal(expected, result);}
    }
}
