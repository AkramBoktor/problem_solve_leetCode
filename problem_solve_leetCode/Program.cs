using System;
using System.Collections.Generic;

namespace Roman_to_Integer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RomanToInt("MCMXCIV"));
        }

        public static int RomanToInt(string s)
        {
            int sumOfRoman = 0;
            string specialCase = string.Empty;
            Dictionary<string, int> Numbers = new Dictionary<string, int>
            {
                {"I",1},{"V",5},{"X",10},{"L",50},{"C",100},{"D",500},{"M",1000}
                ,{"IV",4},{"IX",9},{"XL",40},{"XC",90},{"CD",400},{"CM",900}
            };
            for (int i = 0; i < s.Length ; i++)
            {
                if(i != s.Length-1)
                {
                         specialCase = s[i].ToString() + s[i + 1].ToString();
                        if (Numbers.ContainsKey(specialCase))
                        {
                            sumOfRoman += Numbers[specialCase];
                            i++;
                        }
                        else
                        {
                            sumOfRoman += Numbers[s[i].ToString()];
                        }
                }
                else
                {
                    sumOfRoman += Numbers[s[i].ToString()];
                }
              

            }

            return sumOfRoman;
        }
    }
}
