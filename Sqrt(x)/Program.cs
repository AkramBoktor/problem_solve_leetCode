using System;

namespace Sqrt_x_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Program.MySqrt(24));
            Console.WriteLine(Program.MySqrt(8));
            Console.WriteLine(Program.MySqrt(9));
            Console.WriteLine(Program.MySqrt(4));
        }
        /*
         * 4.89897948556636
            2.82842712474619
            3
            2
*/


        public static decimal MySqrt(int x)
        {
            int sqrt = x / 2;
            int temp = 0;

            // Iterate until sqrt is different of temp, that is updated on the loop
            while (sqrt != temp)
            {
                // initially 0, is updated with the initial value of 128
                // (on second iteration = 65)
                // and so on
                temp = sqrt;

                // Then, replace values (256 / 128 + 128 ) / 2 = 65
                // (on second iteration 34.46923076923077)
                // and so on
                sqrt = (x / temp + temp) / 2;


            }
            return sqrt;


        }
    }
}

