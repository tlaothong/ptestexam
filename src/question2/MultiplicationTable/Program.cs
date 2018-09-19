using System;

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            var tableGenerator = new TableGenerator();
            var result = tableGenerator.Generate(3);
            foreach (var item in result)
            {
                Console.Write(item);
            }
        }
    }
}
