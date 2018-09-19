using System;
using System.Collections.Generic;
using System.Linq;

namespace MultiplicationTable
{
    public class TableGenerator
    {
        public string[] Generate(int inputNumber)
        {
            var table = new List<string>{};
            for (int tableColumHeader = 0; tableColumHeader <= inputNumber; tableColumHeader++)
            {
                if(tableColumHeader == 0) table.Add("*");
                else table.Add(tableColumHeader.ToString());        
            }
            table.Add("\n");

            for (int tableRowHeader = 1; tableRowHeader <= inputNumber; tableRowHeader++)
            {
                table.Add(tableRowHeader.ToString());
                for (int tableRowBody = 1; tableRowBody <= inputNumber; tableRowBody++)
                { 
                    table.Add((tableRowBody * tableRowHeader).ToString());
                }
                table.Add("\n");
            }
            
            return table.ToArray();
        }
    }
}