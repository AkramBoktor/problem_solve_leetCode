/*
 2. Add Two Numbers
You are given two non-empty linked lists representing two non-negative integers. The digits are stored in reverse order, and each of their nodes contains a single digit. Add the two numbers and return the sum as a linked list.

You may assume the two numbers do not contain any leading zero, except the number 0 itself.

 Input: l1 = [2,4,3], l2 = [5,6,4]
Output: [7,0,8]
Explanation: 342 + 465 = 807.
Example 2:

Input: l1 = [0], l2 = [0]
Output: [0]
Example 3:

Input: l1 = [9,9,9,9,9,9,9], l2 = [9,9,9,9]
Output: [8,9,9,9,0,0,0,1]
*/

using System;

namespace _Medium_Add_Two_Numbers_LinkedList
{
 
    class Program
    {
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
 
        static void Main(string[] args)
        {
            //ListNode one = new ListNode(2);
            //ListNode two = new ListNode(4);
            //ListNode three = new ListNode(3);

            //ListNode four = new ListNode(5);
            //ListNode five = new ListNode(6);
            //ListNode six = new ListNode(4);

            ListNode one = new ListNode(9);
            ListNode two = new ListNode(9);
            ListNode three = new ListNode(9);
            ListNode four = new ListNode(9);
            ListNode five = new ListNode(9);
            ListNode six = new ListNode(9);
            ListNode seven = new ListNode(9);



            one.next = two;
            two.next = three;
            three.next = four;
            four.next = five;
            five.next = six;
            six.next = seven;


            ListNode eight = new ListNode(9);
            ListNode nine = new ListNode(9);
            ListNode ten = new ListNode(9);
            ListNode eleven = new ListNode(9);

            eight.next = nine;
            nine.next = ten;
            ten.next = eleven;

            ListNode sumOfTwoList = Program.AddTwoNumbers(one, eight);
            while (sumOfTwoList != null)
            {
                Console.WriteLine(sumOfTwoList.val);
                sumOfTwoList = sumOfTwoList.next;
            }
        }

        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {

            var carry = 0;

            var dummy = new ListNode(-1);

            var cur1 = l1;
            var cur2 = l2;

            var cur = dummy;

            while (cur1 != null || cur2 != null)
            {
                var numberA = cur1 != null ? cur1.val : 0;
                var numberB = cur2 != null ? cur2.val : 0;

                var result = numberA + numberB + carry;

                var remainder = result % 10;

                carry = result / 10;

                cur.next = new ListNode(remainder);

                cur = cur.next;
                if (cur1 != null) cur1 = cur1.next;
                if (cur2 != null) cur2 = cur2.next;
            }

            if (carry != 0)
            {
                cur.next = new ListNode(carry);
            }

            var head = dummy.next;
            dummy.next = null;

            return head;
            //comment
        }
    }
}
