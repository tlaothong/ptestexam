using multiplication.Models;
using System.Collections.Generic;

namespace multiplication
{
    public class MultiplicationLogic
    {
        public MultiplicationTable GetMultiplicationTable(int number)
        {
            return new MultiplicationTable
            {
                Rows = new List<string>
                {
                    "",
                    ""
                }
            };
        }
    }
}