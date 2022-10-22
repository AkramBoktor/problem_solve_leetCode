using System;
using System.Collections.Generic;
using System.Linq;

/*
 * 
 A self-dividing number is a number that is divisible by every digit it contains.

For example, 128 is a self-dividing number because 128 % 1 == 0, 128 % 2 == 0, and 128 % 8 == 0.
A self-dividing number is not allowed to contain the digit zero.

Given two integers left and right, return a list of all the self-dividing numbers in the range [left, right].

 

Example 1:

Input: left = 1, right = 22
Output: [1,2,3,4,5,6,7,8,9,11,12,15,22]
Example 2:

Input: left = 47, right = 85
Output: [48,55,66,77]
 
*/
namespace Self_Dividing_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Join(",", Program.SelfDividingNumbers(1, 22)));
            Console.WriteLine(string.Join(",", Program.SelfDividingNumbers(47, 88)));
        }


        public static IList<int> SelfDividingNumbers(int left, int right)
        {
            IList<int> listDividingNumbers = new List<int>();
            bool validNumber = false;
            for (int number = left; number <= right; number++)
            {
                if(!number.ToString().Contains('0'))
                {
                    validNumber = true;
                    for (int digit = 0; digit < number.ToString().Length; digit++)
                    {
                        if (number % (int)Char.GetNumericValue(number.ToString().ToCharArray()[digit]) != 0)
                        {
                            validNumber = false;
                            break;
                        }
                    }
                    if(validNumber==true) listDividingNumbers.Add(number);

                }
            }

            return listDividingNumbers;
        }
    }
}

/*Solution 2*/
/*
  public IList<int> SelfDividingNumbers(int left, int right)
        {
            IList<int> res = new List<int>();
            for (int i = left; i <= right; i++)
            {
                bool passed = true;
                int num = i;
                while (true)
                {
                    if (num == 0)
                    {
                        break;
                    }

                    int digit = num % 10;

                    if (digit == 0)
                    {
                        passed = false;
                        break;
                    }

                    if (i % digit != 0)
                    {
                        passed = false;
                        break;
                    }

                    num = num / 10;
                }

                if (passed)
                {
                    res.Add(i);
                }
            }

            return res;
        }
*/