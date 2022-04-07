using System;
using System.Collections.Generic;

namespace Palindrome_Linked_List
{
    class Program
    {
        static void Main(string[] args)
        {
            ListNode one = new ListNode(1);
            ListNode two = new ListNode(1);
            ListNode three = new ListNode(2);
            ListNode four = new ListNode(1);
            //ListNode five = new ListNode(3);
            //ListNode six = new ListNode(2);
            //ListNode seven = new ListNode(1);

            one.next = two;
            two.next = three;
            three.next = four;
            //four.next = five;
            //five.next = six;
            //six.next = seven;
            Console.WriteLine(Program.IsPalindrome(one));
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

        public static bool IsPalindrome(ListNode head)
        {
            List<int> listItem = new List<int>();
            ListNode node = head;
            while (node != null)
            {
                listItem.Add(node.val);
                node = node.next;
            }

            for (int i = 0, j = listItem.Count-1; i < listItem.Count/2; i++, j--)
            {
                if (listItem[i] != listItem[j])
                    return false;
                    
            }

            return true ;
        }
    }
}
