using System;
using System.Collections.Generic;

namespace Implement_Stack_using_Queues
{
    class Program
    {
        static void Main(string[] args)
        {
            MyStack myStack = new MyStack();
            myStack.Push(1);
            myStack.Push(2);
            myStack.Top(); // return 2
            myStack.Pop(); // return 2
            Console.WriteLine(myStack.Empty());  // return False
        }

        public class MyStack
        {
            List<int> stackList;
            public MyStack()
            {
                stackList = new List<int>();
            }

            public void Push(int x)
            {
                stackList.Add(x);
            }

            public int Pop()
            {
               int lastItem = stackList[stackList.Count - 1];
                stackList.Remove(stackList[stackList.Count - 1]);
                return lastItem;
            }

            public int Top()
            {
               return stackList[stackList.Count - 1];
            }

            public bool Empty()
            {
                return stackList.Count==0;
            }
        }
    }
}
