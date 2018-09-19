using System;

namespace myLibrary
{
    public class MultiplicationTable
    {
        // public string[,] Calculate(int amount)
        // {
        //     var totalAmount = amount + 1;
        //     var result = new string[totalAmount, totalAmount];

        //     for (int i = 0; i < totalAmount; i++)
        //     {
        //         for (int j = 0; j < totalAmount; j++)
        //         {
        //             if (i == 0 && j == 0) result[i, j] = "*";
        //             else if (i == 0 && j != 0) result[i, j] = (1 * j).ToString();
        //             else if (i != 0 && j == 0) result[i, j] = (i * 1).ToString();
        //             else result[i, j] = (i * j).ToString();
        //         }
        //     }
        //     return result;
        // }

        public string[] Calculate(int amount)
        {
            const int minimumAmount = 1;
            if(amount < minimumAmount) return null;

            var totalAmount = amount + 1;
            var result = new string[totalAmount];

            for (int i = 0; i < totalAmount; i++)
            {
                for (int j = 0; j < totalAmount; j++)
                {
                    if (i == 0 && j == 0) result[i] += "*";
                    else if (i == 0 && j != 0) result[i] += $" {(1 * j)}";
                    else if (i != 0 && j == 0) result[i] += $" {(i * 1)}";
                    else result[i] += $" {(i * j)}";
                }
                result[i] = result[i].Trim();
            }
            return result;
        }

    }
}