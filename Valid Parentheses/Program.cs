using System;
using System.Collections.Generic;

namespace Valid_Parentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Program.IsValid("()[]{}"));
            Console.WriteLine(Program.IsValid("({})"));
            Console.WriteLine(Program.IsValid("({}[[)"));
            Console.WriteLine(Program.IsValid("([)]"));
            Console.WriteLine(Program.IsValid("("));
            Console.WriteLine(Program.IsValid("([]){"));
            Console.WriteLine(Program.IsValid("[[[]"));
        }


        public static bool IsValid(string s)
        {
            #region solution it's valid when (){}[] the parameter follow each others
            //++i to increment the index and the excute the compare
            // it's valid when (){}[] the parameter follow each others
            //for (int i = 0; i < s.Length; i++)
            //{


            //    switch (s[i])
            //    {
            //        case '(':
            //           if( s[++i] != ')') return false;
            //            break;
            //        case '[':
            //            if (s[++i] != ']') return false;
            //            break;

            //        case '{':
            //            if (s[++i] != '}') return false;
            //            break;
            //        default:
            //            return false;
            //    }
            //}
            //return true;
            #endregion

            int j = 0;
            for (int i= 1; i < s.Length; i++)
            {
                j = i-1;
                switch (s[i])
                {
                    case ')':
                        if (s[j]!='(')
                            return false;
                        s = s.Remove(j,2);
                        i = 0;
                        break;
                    case ']':
                        if (s[j] != '[')
                            return false;
                        s = s.Remove(j, 2);
                        i = 0;
                        break;

                    case '}':
                        if (s[j] != '{')
                            return false;
                        s = s.Remove(j, 2);
                        i = 0;
                        break;
                    default:
                        if(i==s.Length-1)
                        return false;
                        break;
                   
                }
            }
            return s.Length == 1 ? false : true;


        }
     }
}

