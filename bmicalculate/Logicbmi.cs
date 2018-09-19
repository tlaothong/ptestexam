namespace bmicalculate
{
    public class Logicbmi
    {
        public double BMI(double weight  , double hight)
        {
            double bmi = weight/(hight*hight)*703;
           return bmi;  
        }
    }
}