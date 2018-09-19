using System;
using Calculator.Models;

namespace Calculator
{
    public class BMICalculator
    {
        public CalculateResult Calculate(double weight, double height)
        {
            const double MinimumBMI = 18.5;
            const double MaximumBMI = 25;
            var suggestMessage = "You're underweight. You should consult your doctor!";

            var isValidInput = weight != 0 && height != 0;
            if (!isValidInput)
            {
                return new CalculateResult{
                    SuggestMessage = "Can't calculate please try again"
                };
            }
            
            var bmi = (weight / (Math.Pow(height, 2))) * 703;
        
            if(bmi >= MinimumBMI && bmi <= MaximumBMI)
            {
                suggestMessage = "You're within the normal weight range.";
            }

            return new CalculateResult{
                BMI = bmi,
                SuggestMessage = suggestMessage
            };
        }
    }
}