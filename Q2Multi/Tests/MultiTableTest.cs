using Xunit;
using System;
using Services;

namespace Tests
{
    public class Hello 
    {
        MultiService svc;
                
        [Fact]
        public void Test2()
        {
            var expected = new long[,] {{1,2}, {2,4}};
            svc = new MultiService();
            var result = svc.GetMultiTable(2);
            Assert.Equal(expected, result);
        }       
                
        [Fact]
        public void Test3()
        {
            var expected = new long[,] {{1,2,3}, {2,4,6}, {3,6,9}};
            svc = new MultiService();
            var result = svc.GetMultiTable(3);
            Assert.Equal(expected, result);
        }
        
        [Fact]
        public void Test4()
        {
            var expected = new long[,] {{1,2,3,4}, {2,4,6,8}, {3,6,9,12},{4,8,12,16}};
            svc = new MultiService();
            var result = svc.GetMultiTable(4);
            Assert.Equal(expected, result);
        }
    }
}