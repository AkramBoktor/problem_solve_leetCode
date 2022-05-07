using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Remove_All_Adjacent_Duplicates_in_String_II
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Join(",", RemoveDuplicates("pbbcggttciiippooaais", 2)));
        }

        public static string RemoveDuplicates(string s, int k)
        {
            StringBuilder sNew = new StringBuilder();
            sNew.Append(s);
            HashSet<int> RemoveDuplicates = new HashSet<int>();
            int i = 0, j  , countofRepeat ;
            int coubtOfCharacters = s.Length;
            while (coubtOfCharacters != 0)
            {
                j = i + 1;
                countofRepeat = 1;
                while (j<= sNew.Length - 1)
                {
                    if (sNew[i] == sNew[j])
                    {
                        RemoveDuplicates.Add(i);
                        RemoveDuplicates.Add(j);
                        countofRepeat++;
                    }
                    j++;
                }
                if (countofRepeat >= k)
                {
                    countofRepeat = k;
                    foreach (var item in RemoveDuplicates)
                    {
                            if (countofRepeat == 0) break;
                           sNew[item] = '-';
                             countofRepeat--;
                    }
                    i = 0;
                }
                else
                {
                    i++;
                }
                sNew = sNew.Replace("-", "");
                coubtOfCharacters--;
                RemoveDuplicates.Clear();
            }


            return sNew.ToString();
        }

        
    }
}

     