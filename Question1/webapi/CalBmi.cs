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

            //int shopbudget = 500;
            double bmi;
            double bmitotal;
            double point;
            height = (height * 2) / 100;
            bmi = (weight / height);
            
            //    if ( bmi > shopbudget )
            //     {

            //         throw new Exception("!! i can't change you cash For Diamond");
            //     }
            //     //Check input should more than 0         
            //     if( mymoney < 0 )
            //     {
            //         //return -1;
            //         throw new Exception("Input less than 0");
            //     }

            //     else
            //     {
            //         return mymoney-price;
            //     }
            // }

            // public  int ChangeMoneyO(int mymoney, int price)
            // {
            //     int shopbudget = 500;
            //     var sumChange = mymoney - price;
            //     if(shopbudChange )
            //     {
            //         //return -1;
            //         throw new Exception("!! i can't change you cash For O");
            //     }

            //     //Check input should more than 0         
            //     if( mymoney < 0 )
            //     {
            //         //return -1;
            //         throw new Exception("Input less than 0");
            //     }
            //     else
            //     {
            //         return mymoney-price;
            //     }
            return bmi;
        }
    }
}