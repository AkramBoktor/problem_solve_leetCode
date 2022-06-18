using System;
using System.Collections.Generic;
using System.Linq;

namespace Min_Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = 0;
            MinStack minStack = new MinStack();
            minStack.Push(2);
            minStack.Push(0);
            minStack.Push(3);
            minStack.Push(0);
            min =   minStack.GetMin(); // return 0
            minStack.Pop();
            min = minStack.GetMin(); // return 0
            minStack.Pop();
           min = minStack.GetMin(); // return 0
            minStack.Pop();
           min = minStack.GetMin(); // return 2
        }

        public class MinStack
        {
            List<int> stackList;

            public MinStack()
            {
                stackList = new List<int>();
            }

            public void Push(int val)
            {
                stackList.Add(val);
            }

            public void Pop()
            {
                stackList.RemoveAt(stackList.Count-1);
            }

            public int Top()
            {
                return stackList[stackList.Count-1];
            }

            public int GetMin()
            {
                return stackList.Min(item => item);
            }
        }
    }
}


/* MinStack() initializes the stack object.
void Push(int val) pushes the element val onto the stack.
void Pop() removes the element on the top of the stack.
int top() gets the top element of the stack.
int GetMin() retrieves the minimum element in the stack.

*********************************
Input
["MinStack","Push","Push","Push","GetMin","Pop","top","GetMin"]
[[],[-2],[0],[-3],[],[],[],[]]

Output
[null,null,null,null,-3,null,0,-2]

Explanation
MinStack minStack = new MinStack();
minStack.Push(-2);
minStack.Push(0);
minStack.Push(-3);
minStack.GetMin(); // return -3
minStack.Pop();
minStack.top();    // return 0
minStack.GetMin(); // return -2

*/

/*
 * ["MinStack","push","push","push","push","getMin","pop","getMin","pop","getMin","pop","getMin"]
[[],[2],[0],[3],[0],[],[],[],[],[],[],[]]

*/