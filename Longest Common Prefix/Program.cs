using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Longest_Common_Prefix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Program.LongestCommonPrefix(new string[] { "flower", "flow", "flight" }));
            //Console.WriteLine(Program.LongestCommonPrefix(new string[] { "dog", "racecar", "car" }));
            //Console.WriteLine(Program.LongestCommonPrefix(new string[] { "flower", "fkow" }));
            //Console.WriteLine(Program.LongestCommonPrefix(new string[] { "cir", "car" }));
            //Console.WriteLine(Program.LongestCommonPrefix(new string[] { "aac", "a", "ccc" }));
            //Console.WriteLine(Program.LongestCommonPrefix(new string[] { "aca", "cba" }));
            //Console.WriteLine("SS" + Program.LongestCommonPrefix(new string[] { "ab", "a" }));
            //Console.WriteLine(Program.LongestCommonPrefix(new string[] { "flower", "flower", "flower", "flower" }));

        }

        public static string LongestCommonPrefix(string[] strs)
        {
            //if (strs.Length == 0 ) return string.Empty;
            //if (strs.Count() == 1) return strs.GetValue(0).ToString();
            ////for orevent exception when the string length of first element of the array less than other 
            //// if it's less will throw exception in line 31
            //strs = strs.OrderByDescending(l => l.Length).ToArray();
            //string prefix =strs[0];
            //StringBuilder longestCommonPrefix = new StringBuilder();
            //Dictionary<int, string> checkLongest = new Dictionary<int, string>();
            //for (int i = 1; i <strs.Length; i++)
            //{
            //    string tempString = string.Empty;
            //    longestCommonPrefix.Clear();
            //    for (int j = 0; j < strs[i].Length; j++)
            //    {
            //        // all lement except last character
            //        // push last character if there's before it another characters
            //        // if the length is one
            //        if (((strs[i][j] == prefix[j]  && j!=strs[i].Length-1)) ||
            //            (j == strs[i].Length - 1 && longestCommonPrefix.Length!=0 && strs[i][j] == prefix[j]) || 
            //            strs[i].Length == 1 && strs[i][j] == prefix[j])
            //        {
            //            longestCommonPrefix.Append(prefix[j]);
            //        }
            //        else
            //        {
            //            if(longestCommonPrefix.ToString().Length > tempString.Length)
            //            {
            //                tempString = string.Empty;
            //                tempString = longestCommonPrefix.ToString();

            //                //this line to get the common ammong all the string not from first
            //                // example ["flower","fkow"] will be ow 
            //                //******longestCommonPrefix.Clear();
            //                /// but the solution need f so write break
            //                break;
            //            }
            //            break;
            //        }

            //    }
            //    checkLongest.Add(i , tempString.Length >= longestCommonPrefix.Length ? tempString : longestCommonPrefix.ToString());
            //}



            //var characterMin =  checkLongest.Where(x => x.Value.Length == checkLongest.Min(m => m.Value.Length)).Select(x => x.Value).FirstOrDefault();
            //foreach (var item in checkLongest)
            //{
            //   if ( !item.Value.Contains(characterMin)) return string.Empty;
            //}
            //return characterMin;



            #region MyRegion
            /// solution from leetcode
            #endregion


            //if (strs == null || strs.Length == 0)
            //    return "";

            //Array.Sort(strs);
            //String first = strs[0];
            //String last = strs[strs.Length - 1];
            //int c = 0;
            //while (c < first.Length)
            //{
            //    if (first[c] == last[c])
            //        c++;
            //    else
            //        break;
            //}
            //return c == 0 ? "" : first.Substring(0, c);

     
                if (strs.Length == 0) return "";
                string prefix = strs[0];
                for (int i = 1; i < strs.Length; i++)
                {
                    while (strs[i].IndexOf(prefix) != 0)
                    {
                        prefix = prefix.Substring(0, prefix.Length - 1);
                        if (prefix == "") return "";
                    }
                }
                return prefix;

         
        }
    }
}
