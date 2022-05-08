using System;
using System.Collections.Generic;

namespace Intersection_of_Two_Linked_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            ListNode one = new ListNode(1);
            ListNode two = new ListNode(2);
            ListNode three = new ListNode(3);
            ListNode four = new ListNode(4);
            ListNode five = new ListNode(2);
            ListNode six = new ListNode(9);

            one.next = two;
            two.next = three;

            four.next = five;
            five.next = six;
            ListNode mergedList = Program.GetIntersectionNode(one, four);
            while (mergedList != null)
            {
                Console.WriteLine(mergedList.val);
            }
        }

        public static ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            List<ListNode> intersection = new List<ListNode>();
            ListNode commonIntersection = null;
            while (headA != null)
            {
                intersection.Add(headA);
                headA = headA.next;
            }

            while (headB != null)
            {
                if (intersection.Contains(headB))
                {
                    commonIntersection = headB;
                    break;
                }
                headB = headB.next;
            }

            return commonIntersection;
        }


        public class ListNode
        {
           public int val;
           public ListNode next;
           public ListNode(int x) { val = x; }
        }
 
    }
}
