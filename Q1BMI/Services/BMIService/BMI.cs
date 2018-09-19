// A Hello World! program in C#.
using System;
namespace BMIService
{
    public class BMI 
    {
        public string GetBMI(double weight, double height)
        {
            var bmi = (weight/Math.Pow(height))*703
            if(bmi > 25)
            {
                return "'You're outerweight. You should consult your doctor!";
            }
            else if(bmi < 18.5)
            {
                return "'You're underweight. You should consult your doctor!!";
            }
            else return "'You're within the normal weight range";
        }
    }
}