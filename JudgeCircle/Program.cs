using System;

namespace JudgeCircle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Program.JudgeCircle("L,R,U,D"));
        }

        public static bool JudgeCircle(string moves)
        {
            int l = 0;
            int r = 0;
            int u = 0;
            int d = 0;
            foreach (char c in moves)
            {
                if (c == 'L') l++;
                if (c == 'R') r++;
                if (c == 'U') u++;
                if (c == 'D') d++;
            }
            return l - r == 0 && u - d == 0;
        }
    }
}
