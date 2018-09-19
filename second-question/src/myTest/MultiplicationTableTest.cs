using System;
using Xunit;
using myLibrary;

namespace myTest
{
    public class MultiplicationTableTest
    {
        [Fact]
        public void MultiplicationTable_Successed()
        {
            var cal = new MultiplicationTable();
            var result =  cal.Calculate(0);
            
        }
    }
}
