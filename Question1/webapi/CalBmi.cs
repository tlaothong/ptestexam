using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
namespace webapi
{
    public class CalBmi
    {
        public double Calculator(double weight, double height)
        {

           
            double bmi;
            double bmitotal;
            double point;

            if( weight>120){
                throw new Exception("Normal people can't have height than 220 and weight than 120");
            }

            if( height>220){
                throw new Exception("Normal people can't have height than 220 and weight than 120");
            }
            else{

            
            height = (height * 2) / 100;
            bmi = (weight / height);
            }
            
        
            return bmi;
        }

       
}
}