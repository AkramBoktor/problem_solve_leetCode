using System;

namespace Number_Of_Steps
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Program.NumberOfSteps(14));
            Console.WriteLine(Program.NumberOfSteps(8));
            Console.WriteLine(Program.NumberOfSteps(123));
        }


        public static int NumberOfSteps(int num)
        {
            int steps= 0;
            while(num!=0)
            {
                num = num % 2 == 0 ? num / 2 : num - 1;
                steps++;
            }
           return steps;
        }
    }
}
