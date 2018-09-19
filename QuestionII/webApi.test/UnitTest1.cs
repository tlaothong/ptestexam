using System;
using Xunit;
using webApi.Controllers;

namespace wevApi.test
{
    public class UnitTest1
    {
        [Fact(DisplayName="ใส่ค่า n แล้วสามารถสร้างตารางได้ถูกต้อง")]
        public void Test1()
        {
            var test = new multiTable();
            test.printTable(3);
            Assert.Equal(1,test.Number[0][0]);
            Assert.Equal(2,test.Number[0][1]);
            Assert.Equal(3,test.Number[0][2]);
            Assert.Equal(2,test.Number[1][0]);
            Assert.Equal(4,test.Number[1][1]);
            Assert.Equal(6,test.Number[1][2]);
            Assert.Equal(3,test.Number[2][0]);
            Assert.Equal(6,test.Number[2][1]);
            Assert.Equal(9,test.Number[2][2]);
        }
    }
}
