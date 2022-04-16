using System;
using System.Collections.Generic;

namespace Merge_Two_Sorted_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            ListNode one = new ListNode(1);
            ListNode two = new ListNode(2);
            ListNode three = new ListNode(4);
            ListNode four = new ListNode(1);
            ListNode five = new ListNode(3);
            ListNode six = new ListNode(4);
            //ListNode seven = new ListNode(1);

            one.next = two;
            two.next = three;

            four.next = five;
            five.next = six;
            ListNode mergedList = Program.MergeTwoLists(one, four);
            while (mergedList != null)
            {
                Console.WriteLine(mergedList.val);
                mergedList = mergedList.next;
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

            public static ListNode MergeTwoLists(ListNode list1, ListNode list2)
            {
                      List<int> sortedList = new List<int>();
                      ListNode mergeTwoListNode = new ListNode() ;

            if (list1 == null && list2 == null) return null;

                    while (list1 != null)
                    {
                         sortedList.Add(list1.val);
                          list1=list1.next;
                    }

                    while (list2 != null)
                    {
                        sortedList.Add(list2.val);
                        list2 = list2.next;
                    }

                      sortedList.Sort();

                    for (int i = sortedList.Count-1; i >= 0 ; i--)
                    {
                          ListNode newNode = new ListNode(sortedList[i]);
                          if(i!=0)
                          newNode.next = mergeTwoListNode;

                          mergeTwoListNode = newNode;
                    }

                  return mergeTwoListNode;
               
        }
    }
}
