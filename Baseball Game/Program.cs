using System;
using System.Collections.Generic;
using System.Linq;

namespace Baseball_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Program.CalPoints(new string[] { "5", "2", "C", "D", "+" }));
        }


        public static int CalPoints(string[] ops)
        {
            Stack<int> calPoints = new Stack<int>();
            for (int i = 0; i < ops.Length; i++)
            {
                if (ops[i] == "C")
                    calPoints.Pop();
                //  if i used it calPoints.RemoveAt(i--); will throw exception because it's execute remove then subcart 1 from i
                else if (ops[i] == "D")
                    calPoints.Push(calPoints.Peek() * 2);
                else if (ops[i] == "+")
                {
                    int temp1 = calPoints.Pop();
                    int temp2 = calPoints.Peek();
                    calPoints.Push(temp1);
                    calPoints.Push(temp1 + temp2);
                }
                  
                else
                    calPoints.Push(Convert.ToInt32(ops[i]));
            }


            return calPoints.Sum();
        }
    }
}
