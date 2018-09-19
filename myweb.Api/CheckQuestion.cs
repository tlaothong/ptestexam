using System;

namespace myweb.Api
{
    public class CheckQuestion
    {
        public double QuestionI(double weight, double height)
        {
            double bmi = (weight / ((height / 100) * (height / 100)));
            double bmiMR = Math.Round(bmi, 2);
            return bmiMR;
        }

        public string QuestionII(int number)
        {

            var tt = "";
            for (int i = 0; i <= number; i++)
            {

                tt += i.ToString();


                for (int j = 1; j <= number; j++)
                {
                    if (i > 0)
                    {
                        tt += i * j;
                    }
                    else
                    {
                        tt += j;
                    }
                }
                tt += "\n";
                Console.Write("\n");
            }
            return tt;
        }
    }
}