using System;
using Xunit;
using webapi.Controllers;

namespace webapi.test
{
    public class UnitTest1
    {
        [Theory(DisplayName = "แปลงน้ำหนักจากกิโลกรัม เป็นปอนด์ได้ถูกต้อง")]
        [InlineData(10,22.046)]
        [InlineData(50,110.23)]
        [InlineData(69,152.1174)]
        public void TestChangeWeight(double kg,double expected)
        {
            var test = new calc();
            var weight = test.changeWeight(kg);
            Assert.Equal(expected, weight);
        }

        [Theory(DisplayName = "แปลงส่วนสูงจากเซนติเมตร เป็นนิ้วได้ถูกต้อง")]
        [InlineData(10,3.9370)]
        [InlineData(170,66.929)]
        [InlineData(165,64.9605)]
        public void TestChangeHeight(double cm,double expected)
        {
            var test = new calc();
            var height = test.changeHeight(cm);
            Assert.Equal(expected, height);
        }

        [Theory(DisplayName = "รับค่า weight และ height ระบบคำนวน BMI และส่งค่า BMI กลับมาได้ถูกต้อง")]
        [InlineData(10, 10, 70.3)]
        [InlineData(50, 100, 3.515)]
        [InlineData(100, 200, 1.7575)]
        public void TestBMI(double weight, double height, double expected)
        {
            var test = new calc();
            var bmi = test.calcBmi(weight, height);

            Assert.Equal(expected, bmi);
        }


    }
}
