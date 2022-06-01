using System;

namespace Rotate_String
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Program.RotateString("abcde", "cdeab"));
            Console.WriteLine(Program.RotateString("abcde", "abced"));
            Console.WriteLine(Program.RotateString("abcde", "bcdea"));
        }


        public static bool RotateString(string s, string goal)
        {
            char [] arrRotated = new char[s.Length];
            arrRotated = s.ToCharArray();
            int count = 0;
            while(count < arrRotated.Length)
            {
              char FirstCahracter = arrRotated[0];

                for (int j = 0; j < arrRotated.Length; j++)
                {
                    arrRotated[j] = j == arrRotated.Length - 1 ?  FirstCahracter : arrRotated[j + 1];

                    
                }
                if(new string(arrRotated) == goal)
                {
                    return true;
                }
                count++;
            }

            return false;
        }
    }
}


//        return (s + s).Contains(goal) && s.Length == goal.Length;
