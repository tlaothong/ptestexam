using System;

namespace Services
{
    public class BMI
    {
        static void Main(string[] args)
        {

        }
        // public string Resultbmithai(double weight, double height)
        // {
        //     var bmi = (weight / ((height / 100) * (height / 100)));
        //     if (bmi >= 30)
        //     {
        //         return "Obese 3";
        //     }
        //     else if (bmi >= 25 && bmi < 30)
        //     {
        //         return "Obese 2";
        //     }
        //     else if (bmi >= 23 && bmi < 25)
        //     {
        //         return "Obese 1";
        //     }
        //     else if (bmi >= 18.5 && bmi < 23)
        //     {
        //         return "Normal weight";
        //     }
        //     else
        //     {
        //         return "Underweight";
        //     }
        // }

        public string Resultbmi(double weight, double height)
        {
            //1 kilogram =2.20462262 pounds
            // bmi=(weight/(height ^2 ))∗703
            var ibs = height*0.393;
            var bmi = ((weight*2.20462262) / (ibs * ibs))*703;
            if (bmi > 25)
            {
                return "You are somewhat overweight.";
            }
            else if (bmi < 18.5)
            {
                return "You are somewhat underweight.";
            }
            else if (bmi > 18.5 && bmi < 25)
            {
                return "Congratulations! You are within a healthy weight range.";
            }
            else
            {
                return "";
            }
        }
    }
}
