using System;

namespace Remove_Elements_List_Nodes
{
    class Program
    {
        static void Main(string[] args)
        {
            ListNode one = new ListNode(1);
            ListNode two = new ListNode(2);
            ListNode three = new ListNode(6);
            ListNode four = new ListNode(3);
            ListNode five = new ListNode(4);
            ListNode six = new ListNode(5);
            ListNode seven = new ListNode(6);
            one.next = two;
            two.next = three;
            three.next = four;

            four.next = five;
            five.next = six;
            six.next = seven;
            ListNode removeList = Program.RemoveElements(one, 6);
            while (removeList != null)
            {
                Console.WriteLine(removeList.val);
                removeList = removeList.next;
            }
        }


        public static ListNode RemoveElements(ListNode head, int val)
        {
            ListNode prev = null;
            var curr = head;
            while (curr != null)
            {
                if (curr.val == val)
                {
                    if (prev != null)
                        prev.next = curr.next;
                    else {
                        head = curr.next;
                            }
                }
                else prev = curr;

                curr = curr.next;
            }

            return head;
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
    }
}

/*
 Input: head = [1,2,6,3,4,5,6], val = 6
Output: [1,2,3,4,5]
Example 2:

Input: head = [], val = 1
Output: []
 */