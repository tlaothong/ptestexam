using multiplication.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace multiplication
{
    public class MultiplicationLogic
    {
        public MultiplicationTable GetMultiplicationTable(int number)
        {
            const int MinimumValue = 1;
            if (number < MinimumValue) return new MultiplicationTable { Rows = Enumerable.Empty<string>() };
            
            var rows = new List<string>();
            var textInRow = new StringBuilder();
            rows.Add(GenerateFirstRow(number));
            var rowNo = 1;
            for (int column = 1; column <= number; column++)
            {
                textInRow.Append(rowNo++);
                for (int row = 1; row <= number; row++)
                {
                    textInRow.Append($" {column * row}");
                }
                rows.Add(textInRow.ToString());
                textInRow.Clear();
            }
            return new MultiplicationTable
            {
                Rows = rows
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