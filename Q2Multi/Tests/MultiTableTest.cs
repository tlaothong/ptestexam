using Xunit;
using System;
using Services;

namespace Tests
{
    public class Hello 
    {
        MultiService svc;
                
        [Theory]
        [InlineData(3)]
        public void Test3(long n)
        {
            var expected = new long[,] {{1,2,3}, {2,4,6}, {3,6,9}};
            svc = new MultiService();
            var result = svc.GetMultiTable(n);
            Assert.Equal(expected, result);
        }
    }
}