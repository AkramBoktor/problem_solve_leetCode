using System;
using System.Collections.Generic;

namespace Fizz_Buzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Join(",",Program.FizzBuzz(15)));
        }


        public static IList<string> FizzBuzz(int n)
        {
            IList<string> fizzList = new List<string>();

            for (int number = 1; number <= n; number++)
            {
                //if(number%3 == 0 && number%5 == 0)
                //{
                //    fizzList.Add("FizzBuzz");
                //}
                //else if (number % 3 == 0)
                //{
                //    fizzList.Add("Fizz");
                //}
                //else if(number % 5 == 0)
                //{
                //    fizzList.Add("Buzz");
                //}
                //else
                //{
                //    fizzList.Add(number.ToString());
                //}

               fizzList.Add(number % 3 == 0 && number % 5 == 0 ? "FizzBuzz" : number % 3 == 0 ? "Fizz" : number % 5 == 0 ? "Buzz" : number.ToString());
            }
            return fizzList;
        }
    }
}
