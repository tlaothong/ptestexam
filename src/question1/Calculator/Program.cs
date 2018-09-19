using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var bmiCalculator = new BMICalculator();
            var result = bmiCalculator.Calculate(50, 40);
            Console.WriteLine($"Your BMI: {result.BMI}");
            Console.WriteLine(result.SuggestMessage);
        }
    }
}
