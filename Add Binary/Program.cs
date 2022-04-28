using System;
using System.Numerics;

namespace Add_Binary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Program.AddBinary("11", "1"));
            Console.WriteLine(Program.AddBinary("11", ""));
        }


        public static string AddBinary(string a, string b)
        {
            if (!string.IsNullOrEmpty(a) && string.IsNullOrEmpty(b))
                return a.ToString();
            if (string.IsNullOrEmpty(a) && !string.IsNullOrEmpty(b))
                return b.ToString();
            else
            {
                return Convert.ToString(Convert.ToInt32(a,2) + Convert.ToInt32(b, 2), 2).PadLeft(a.Length > b.Length? a.Length:b.Length, '0');
            }


        }
    }
}
