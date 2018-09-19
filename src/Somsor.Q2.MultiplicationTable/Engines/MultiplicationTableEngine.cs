using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Somsor.Q2.MultiplicationTable.Engines
{
    public class  MultiplicationTableEngine
    {
        public IEnumerable<IEnumerable<int>> GenerateMultiplicationTable(int n)
        {
            var rows = GenerateNumber(n);
            var columns = GenerateNumber(n);
            var tables = rows.Select(x => columns.Select(y => MultiplyNumber(x, y)));

            return tables;
        }

        public IEnumerable<int> GenerateNumber(int n)
        {
            return Enumerable.Range(1, n);
        }

        public int MultiplyNumber(int n, int m)
        {
            return n * m;
        }
    }
}
