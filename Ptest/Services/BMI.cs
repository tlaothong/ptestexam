using System;

namespace Services
{
    public class BMI
    {
        static void Main(string[] args)
        {

        }
        public string Resultbmi(double weight, double height)
        {
            var bmi = (weight / ((height / 100) * (height / 100)));
            if(bmi>=30){
            return "อ้วนมาก/โรคอ้วนระดับ 3";
            }else if(bmi>=25&&bmi>30){
            return "อ้วนมาก / โรคอ้วนระดับ 2";
            }else if(bmi>=23&&bmi>25){
            return "อ้วนมาก / โรคอ้วนระดับ 1";
            }else if(bmi>=18.5&&bmi>23){
            return "ปกติ (สุขภาพดี)";
            }else{
            return "น้ำหนักน้อย / ผอม";
            }
        }
    }
}
