using System;
using System.Collections.Generic;

namespace Shift_2D_Grid
{
    class Program
    {
        static void Main(string[] args)
        {
            //IList<IList<int>> shifted = Program.ShiftGrid(new int[][] { 
            //                  new int[]  { 953,-882,470,-684,-617,-973,799,615,-967},
            //                  new int[] {-273,-801,668,-907,-142,945,351,721,63},
            //                  new int[] { -506, -952, -446, 84, -378, 85, -536, 266, -820 },

            //                  new int[] { 828, -915, 28, 719, -914, 249, 105, -815, 664},
            //                  new int[] { -161, -340, 303, -992, 519, 592, -808, -209, -168 },
            //                  new int[] { 538, -120, -490, -137, 463, -389, 368, -824, 396},
            //                  new int[] { 73,285,-176,-686,500,-386,-817,-934,-95 },
            //                  new int[] { 129,705,919,-514,956,750,173,976,-894},
            //                  new int[] {-339,-821,-619,0,-884,114,-768,750,250},
            //}, 1);

            IList<IList<int>> shifted = Program.ShiftGrid(new int[][] { new int[] {1},
                              new int[] {2},
                              new int[] {3},
                              new int[] {4},
                              new int[] {7},
                              new int[] {6},
                              new int[] {5} }
                                           , 23);
            //IList<IList<int>> shifted = Program.ShiftGrid(new int[][] { new int[] { 100 } }, 0);

            foreach (var itemValue in shifted)
            {
                foreach (var element in itemValue)
                {
                    Console.WriteLine(element);
                }

                Console.WriteLine();
            }

        }

        public static IList<IList<int>> ShiftGrid(int[][] grid, int k)
        {
            int[][] shiftedGrid = CreateArray(grid);

            while (k != 0)
            {
                shiftedGrid = CreateArray(grid);
                for (int row = 0; row < grid.Length; row++)
                {
                    for (int col = 0; col < grid[row].Length; col++)
                    {
                         if( grid[row].Length > 1 )
                         {

                            if (col == grid[row].Length - 1 && row == grid[row].Length - 1)

                                shiftedGrid[0][0] = grid[row][col];

                            else if (col == grid[row].Length - 1)

                                shiftedGrid[row + 1][0] = grid[row][col];

                            else
                                shiftedGrid[row][col + 1] = grid[row][col];
                        }
                        else
                        {
                            if(row == grid.Length - 1)
                            {
                                shiftedGrid[0][col] = grid[row][col];
                            }
                            else
                                shiftedGrid[row+1][col] = grid[row][col];

                        }



                    }
                }
                grid = shiftedGrid;
                k--;
            }

            return grid;

        }

        static T[][] CreateArray<T>(T[][] grid)
        {
            T[][] array = new T[grid.Length][];
            for (int i = 0; i < array.GetLength(0); i++)
                array[i] = new T[grid[i].Length];

            return array;
        }
    }
 }

