using System;

namespace Climb_Stairs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Program.ClimbStairs(5));
        }

        public static int ClimbStairs(int n)
        {
            //if (n <= 2)
            //    return n;

            //int[] res = new int[n + 1];

            //res[1] = 1;
            //res[2] = 2;

            //for (int i = 3; i <= n; i++)
            //    res[i] = res[i - 1] + res[i - 2];

            //return res[n];

            //if (n < 3)
            //    return n;

            int n_2 = 2;
            int n_1 = 1;
            int res = 0;

            int i = 3;
            while (i++ <= n)
            {
                res = n_2 + n_1;
                n_1 = n_2;
                n_2 = res;
            }

            return res;

        }
    }
}
