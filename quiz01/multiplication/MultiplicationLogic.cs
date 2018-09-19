using multiplication.Models;
using System.Collections.Generic;
using System.Linq;

namespace multiplication
{
    public class MultiplicationLogic
    {
        public MultiplicationTable GetMultiplicationTable(int number)
        {
            var firstRow = GenerateFirstRow(number);
            return new MultiplicationTable
            {
                Rows = new List<string>
                {
                    "",
                    ""
                }
            };
        }

        public string GenerateFirstRow(int number)
        {
            var numbers = Enumerable.Range(1, number);
            var firstRow = "* " + string.Join(" ", numbers);
            return firstRow;
        }
    }
}