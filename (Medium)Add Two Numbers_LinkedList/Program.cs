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
            ListNode one = new ListNode(2);
            ListNode two = new ListNode(4);
            ListNode three = new ListNode(3);

            ListNode four = new ListNode(5);
            ListNode five = new ListNode(6);
            ListNode six = new ListNode(4);

            //ListNode one = new ListNode(9);
            //ListNode two = new ListNode(9);
            //ListNode three = new ListNode(9);
            //ListNode four = new ListNode(9);
            //ListNode five = new ListNode(9);
            //ListNode six = new ListNode(9);
            //ListNode seven = new ListNode(9);



            one.next = two;
            two.next = three;

            four.next = five;
            five.next = six;
            //six.next = seven;


            //ListNode eight = new ListNode(9);
            //ListNode nine = new ListNode(9);
            //ListNode ten = new ListNode(9);
            //ListNode eleven = new ListNode(9);

            //eight.next = nine;
            //nine.next = ten;
            //ten.next = eleven;

            ListNode sumOfTwoList = Program.AddTwoNumbers(one, four);
            while (sumOfTwoList != null)
            {
                Console.WriteLine(sumOfTwoList.val);
                sumOfTwoList = sumOfTwoList.next;
            }
        }

        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
       
            int sumOfTwoDigit = 0;
            int restOfSum = 0;
            ListNode nodeAddTwoNumbers = new ListNode();
            while (l1 != null || l2 !=null)
            {
                sumOfTwoDigit = 0;
                if (restOfSum != 0 && l1 != null && l2 != null)
                {
                    sumOfTwoDigit = l1.val + l2.val + restOfSum;
                    l2 = l2.next;
                    l1 = l1.next;
                    restOfSum = 0;
                }
                   
                else if (restOfSum == 0 && l1 != null && l2 != null)
                {
                    sumOfTwoDigit = l1.val + l2.val;
                    l2 = l2.next;
                    l1 = l1.next;
                }
                   
                else if (restOfSum != 0 && l1 == null && l2 != null)
                {
                    sumOfTwoDigit = l2.val + restOfSum;
                    l2 = l2.next;
                    restOfSum = 0;
                }

                else if (restOfSum != 0 && l1 != null && l2 == null)
                {
                    sumOfTwoDigit = l1.val + restOfSum;
                    l1 = l1.next;
                    restOfSum = 0;

                }
                else if (restOfSum == 0 && l1 == null && l2 != null)
                {
                    sumOfTwoDigit = l2.val;
                    l2 = l2.next;

                }
                else if (restOfSum == 0 && l1 != null && l2 == null)
                {
                    sumOfTwoDigit = l1.val;
                    l1 = l1.next;

                }
                else
                {
                    sumOfTwoDigit = l2.val;
                    l2 = l2.next;

                }

                if ( sumOfTwoDigit >= 10)
                {
                    restOfSum = sumOfTwoDigit / 10;
                    sumOfTwoDigit = sumOfTwoDigit  % 10; 

                }
                ListNode newNode = new ListNode(sumOfTwoDigit);
                newNode.next = nodeAddTwoNumbers;
                nodeAddTwoNumbers.val = sumOfTwoDigit;
                nodeAddTwoNumbers = newNode;


            }
            if (restOfSum != 0) nodeAddTwoNumbers.val = restOfSum;
            return nodeAddTwoNumbers;
        }
    }
}
