// A Hello World! program in C#.
using System;
namespace BMIService
{
    public class BMI 
    {
        public string GetResult(double bmi)
        {
            if(bmi > 25)
            {
                return "You're overweight. You should consult your doctor";
            }
            else if(bmi < 18.5)
            {
                return "You're underweight. You should consult your doctor";
            }
            else return "You're within the normal weight range";
        }
        
        public double GetBMI(double weight, double height)
        {
            return (weight/(Math.Pow(height,2)))*703;
        }
        
        
    }
}