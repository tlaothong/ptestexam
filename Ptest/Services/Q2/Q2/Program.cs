using System;
using System.Linq;

namespace MultiTable
{
    public class Program
    {
        static void Main(string[] args)
        {
            var input = 0;
            Console.Write("Input the N: ");
            input = int.Parse(Console.ReadLine());
            var Ctrl = new Multiplication();
            Ctrl.DisplayMultiplication(input);
        }
    }

    public class Multiplication
    {
        public void DisplayMultiplication(int input)
        {
            var message = getHeader(input);
            Console.WriteLine(message);
            for(var i = 1; i <= input; i++)
            {
                var rowMessage = getRow(i, input);
                Console.WriteLine(rowMessage);
            }
        }

        public string getHeader(int input)
        {
            var header = string.Empty;
            for(var i = 0; i <= input; i++)
                header += i == 0 ? "*\t" : $"{i}\t";
            return header.Trim();
        }

        public string getRow(int rowNumber, int input)
        {
            var row = string.Empty;
            for(var i = 0; i <= input; i++)
                row += i == 0 ? $"{rowNumber}\t" : $"{i*rowNumber}\t";
            return row.Trim();
        }
    }
}