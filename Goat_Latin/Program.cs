/*
 * You are given a string sentence that consist of words separated by spaces. Each word consists of lowercase and uppercase letters only.

We would like to convert the sentence to "Goat Latin" (a made-up language similar to Pig Latin.) The rules of Goat Latin are as follows:

If a word begins with a vowel ('a', 'e', 'i', 'o', or 'u'), append "ma" to the end of the word.
For example, the word "apple" becomes "applema".
If a word begins with a consonant (i.e., not a vowel), remove the first letter and append it to the end, then add "ma".
For example, the word "goat" becomes "oatgma".
Add one letter 'a' to the end of each word per its word index in the sentence, starting with 1.
For example, the first word gets "a" added to the end, the second word gets "aa" added to the end, and so on.
Return the final sentence representing the conversion from sentence to Goat Latin.
*/
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Goat_Latin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Join(",", Program.ToGoatLatin("I speak Goat Latin")));
            //Output: "Imaa peaksmaaa oatGmaaaa atinLmaaaaa"
            //Imaa peaksmaaa oatGmaaaa atinLmaaaaa
        }

        public static string ToGoatLatin(string sentence)
        {
            var colllectionStr = sentence.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(w => new StringBuilder(w)).ToArray();
            StringBuilder goatLatinStr = new StringBuilder();
            string addChatacterA = string.Empty;
            foreach (var str in colllectionStr)
            {

            
                if (!string.IsNullOrWhiteSpace(str.ToString()))
                {
                    addChatacterA += "a";
                    if (str.ToString().ToLower().StartsWith("a") || str.ToString().ToLower().StartsWith("e")
                         || str.ToString().ToLower().StartsWith("i") || str.ToString().ToLower().StartsWith("o")
                         || str.ToString().ToLower().StartsWith("u"))
                    {
                        goatLatinStr.Append(str + "ma" + addChatacterA + " ");
                    }
                    else
                    {
                        var strWithoutFirstCharacter = str.ToString().Substring(1, str.ToString().Length - 1);
                        goatLatinStr.Append(strWithoutFirstCharacter + str.ToString().Substring(0,1) + "ma" + addChatacterA + " ");
                    }

                }

            }
            return goatLatinStr.ToString().TrimEnd();
        }
    }
}
