using System;
using System.Collections.Generic;

namespace _Medium_Palindrome_Partitioning
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Program.Partition("aab"));
        }



        public static IList<IList<string>> Partition(string s)
        {
            List<string> partitionList = new List<string>();

           var strTocharArray = s.ToCharArray();

            string strBind = string.Empty;
            for (int i = 0; i < strTocharArray.Length; i++)
            {
                strBind += strTocharArray[i];
                partitionList.Add(strBind);
                for (int j = i+1; j < strTocharArray.Length; j++)
                {
                    if (strTocharArray[j] == strTocharArray[i])
                    {
                        strBind += strTocharArray[j];
                        partitionList.Add(strBind);
                    }
                    else
                    {
                        strBind += strTocharArray[j];
                        var plaindromCharArray = strBind.ToCharArray();
                        Array.Reverse(plaindromCharArray);
                        if (s == new string(plaindromCharArray))
                        {
                            partitionList.Add(strBind);
                        }
                    }
                }
            }

            return null;
        }
    }
}
