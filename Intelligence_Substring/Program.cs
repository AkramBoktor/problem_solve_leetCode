using System;

namespace Intelligence_Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Program.getSpecialSubString("giraffe", 2, "01111001111111111011111111"));
            try
            {
                test();
                Console.WriteLine("A");
            }
            catch (Exception e)
            {
                Console.WriteLine("B");

            }
            finally
            {
                Console.WriteLine("C");

            }
            Console.WriteLine("D");

        }

        public static void test() { }
        public static int getSpecialSubString(string str, int k, string bitString)
        {
            int n = str.Length;
            int len = 0;
            int i = 0;
            int cnt = 0;
            for (int j = 0; j < n; j++)
            {
                int pos = str[j] - 'a';
                if (bitString[pos] == '0')
                    cnt++;
                while (cnt > k && i < n)
                {
                    pos = str[i] - 'a';
                    if (bitString[pos] == '0')
                        cnt--;
                    i++;
                }
                len = Math.Max(len, j - i + 1);
            }
            return len;
        }
    }
}