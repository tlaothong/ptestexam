using System;

namespace bmiapi {
    public class calculatelogic {
        public double bmi (double weight, double height) 
        {
            double result;
             result = ((height * height) / 10000);
            result = weight/result;

            //result = result*703;  //mass(lbs)
            return result;
        }

    }
}


            

            