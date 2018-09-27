using ptestapi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ptestapi
{
    public class Q1
    {
        public BMIResponse BmiCal(double weight, double height)
        {
            var bmi = (weight / (height*height)) * 703;

            if (bmi < 15.5)
            {
                return new BMIResponse { BMI = bmi, Message = "You're underweight. You should consult your doctor!" };
            }
            else if (bmi > 25)
            {
                return new BMIResponse { BMI = bmi, Message = "You're overweight. You should consult your doctor!" };
            }
            else
            {
                return new BMIResponse { BMI = bmi, Message = "You're within the normal weight range." };
            }
        }
    }
}
