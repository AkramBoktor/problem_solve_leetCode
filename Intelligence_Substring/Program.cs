using System;
using System.Collections.Generic;
using System.Linq;

namespace Intelligence_Substring
{
    class Program
    {
        public class Invoice
        {
            public int id { get; set; }
            public string name { get; set; }
        }
        static void Main(string[] args)
        //{
        //    Console.WriteLine(Program.getSpecialSubString("giraffe", 2, "01111001111111111011111111"));
        //    try
        //    {
        //        test();
        //        Console.WriteLine("A");
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine("B");

        //    }
        //    finally
        //    {
        //        Console.WriteLine("C");

        //    }
        //    Console.WriteLine("D");
        { 
            List<int> ids = new List<int>();
            ids.Add(1);
            ids.Add(3);
            ids.Add(2);
            ids.Add(4);
       
        List<Invoice> objects = new List<Invoice>
        {
            new Invoice{id=1,name="Akram"},
            new Invoice{id=2,name="Boktor"},
            new Invoice{id=3,name="Ibrahim"},

        };

           var r =  objects.Where(s => ids.Contains(s.id)).Select(s => new Invoice
            {
                id = s.id,
                name = s.name,
            }).ToList();
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