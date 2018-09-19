using System;

namespace BmiApi.Models
{
    public class BmiModel
    {
        public double weight { get; set; }
        public double height { get; set; }
        public double bmi { get; set; }
        public string bmiStatus { get; set; }

    }
}