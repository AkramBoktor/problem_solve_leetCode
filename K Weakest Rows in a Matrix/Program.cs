using System;
using System.Collections.Generic;
using System.Linq;

namespace K_Weakest_Rows_in_a_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] kWeakestArray =  Program.KWeakestRows(
            //    new int[][] { new int[] { 1, 1, 0, 0,0 },
            //                  new int[] { 1, 1, 1,1, 0 },
            //                  new int[] { 1, 0, 0, 0 ,0},
            //                  new int[] { 1, 1, 0, 0,0 },
            //                  new int[] { 1, 1, 1, 1 ,1}}
            //                , 3);
            int[] kWeakestArray = Program.KWeakestRows(
                new int[][] { new int[] { 1,0},
                              new int[] { 1,0},
                              new int[] { 1,0},
                              new int[] { 1,1} }
                            , 4);
            Console.WriteLine(string.Join(",", kWeakestArray));
            
        }


        public static int [] KWeakestRows(int[][] mat, int k)
        {
            Dictionary<int, int> soliderDictionary = new Dictionary<int, int>();
            int[] KWeakestRows = new int[k];
            for (int row = 0; row < mat.Length; row++)
            {
                int soliderCount = 0;
                for (int col = 0; col < mat[row].Length; col++)
                {
                    if (mat[row][col] == 1) soliderCount++;

                }
                soliderDictionary.Add(row, soliderCount);
            }

            soliderDictionary = soliderDictionary.OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
            for (int i = 0; i < k; i++)
            {
                KWeakestRows[i] = soliderDictionary.ElementAt(i).Key;
            }
            return KWeakestRows;
        }
    }
}