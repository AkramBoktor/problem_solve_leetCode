using System;
using System.Collections.Generic;

namespace Middle_of_the_Linked_List
{
    class Program
    {
        static void Main(string[] args)
        {
            ListNode one = new ListNode(1);
            ListNode two = new ListNode(2);
            ListNode three = new ListNode(3);
            ListNode four = new ListNode(4);
            ListNode five = new ListNode(5);
            //ListNode six = new ListNode(2);
            //ListNode seven = new ListNode(1);

            one.next = two;
            two.next = three;
            three.next = four;
            four.next = five;
         ListNode newMiddleNode =  Program.MiddleNode(one);
            while (newMiddleNode != null)
            {
                Console.WriteLine(newMiddleNode.val);
                newMiddleNode= newMiddleNode.next;
            }
        }

        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }

        public static ListNode MiddleNode(ListNode head)
        {
            List<int> listNode = new List<int>();
            ListNode middleListNode = head;

            while (middleListNode != null)
            {
                listNode.Add(middleListNode.val);
                middleListNode = middleListNode.next;
            }

             middleListNode = head;
            int middleNumbers = listNode.Count / 2;

            for (int i = 0; i < middleNumbers; i++)
            {
                middleListNode = middleListNode.next;
            }

            return middleListNode;
        }
    }
}
