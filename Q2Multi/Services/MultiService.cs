// A Hello World! program in C#.
using System;
namespace Services
{
    public class MultiService
    {
        public long[,] GetMultiTable(long n)
        {
            var result = new long[n, n];
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    result[i-1,j-1] = i * j;
                }
            }
            return result;
        }
    }
}