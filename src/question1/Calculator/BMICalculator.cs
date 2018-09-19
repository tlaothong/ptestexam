using System;
using Calculator.Models;

namespace Calculator
{
    public class BMICalculator
    {
        public CalculateResult Calculate(double weight, double height)
        {
            var bmi = (weight / (Math.Pow(height, 2))) * 703;
            var suggestMessage = "You're within the normal weight range.";
            
            return new CalculateResult{
                BMI = bmi,
                SuggestMessage = suggestMessage
            };
        }
    }
}