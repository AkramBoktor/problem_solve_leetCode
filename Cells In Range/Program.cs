using System;
using System.Collections.Generic;

namespace Cells_In_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Join(',', Program.CellsInRange( "A1:C1")));
        }

        public static IList<string> CellsInRange(string s)
        {
            List<string> outputCells = new List<string>();
            int rowStart = int.Parse(s[1].ToString());
            int rowEnd = int.Parse(s[s.Length - 1].ToString());

            int colStart = Convert.ToInt32(s[0]);
            int colEnd = Convert.ToInt32(s[s.Length - 2]);
            for (int i = colStart; i <= colEnd; i++)
            {
                for (int j = rowStart; j <= rowEnd; j++)
                {
                    outputCells.Add(Convert.ToChar(i) + j.ToString());
                }
            }
            return outputCells;
        }
    }
}
