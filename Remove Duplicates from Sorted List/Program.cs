using System;
using System.Collections.Generic;
using System.Linq;

namespace Remove_Duplicates_from_Sorted_List
{
    class Program
    {
        static void Main(string[] args)
        {
            ListNode one = new ListNode(1);
            ListNode two = new ListNode(2);
            ListNode three = new ListNode(3);
            ListNode four = new ListNode(8);
            ListNode five = new ListNode(2);
          

            one.next = two;
            two.next = three;
            three.next = four;
            four.next = five;
            ListNode newNodeDeleteDuplicates =  Program.DeleteDuplicates(one);
            while (newNodeDeleteDuplicates != null)
            {
                Console.WriteLine(newNodeDeleteDuplicates.val);
                newNodeDeleteDuplicates = newNodeDeleteDuplicates.next;
            }
        }


        public static ListNode DeleteDuplicates(ListNode head)
        {
            if (head == null) return null;
            HashSet<int> newListSorted = new HashSet<int>();
            ListNode newListNodeWithoutDuplicated = new ListNode();
            while(head!=null)           
            {
               
                    newListSorted.Add(head.val);
                    head = head.next;

            }

            newListSorted = newListSorted.Reverse().ToHashSet();

            foreach (var item in newListSorted.Select((value,i)=> new {value,i}))
            { 
                    ListNode newNode = new ListNode(item.value);
                    if (item.i != 0)
                    newNode.next = newListNodeWithoutDuplicated;
                    newListNodeWithoutDuplicated = newNode;
            }
            return newListNodeWithoutDuplicated;

            #region by list 
            //public ListNode DeleteDuplicates(ListNode head)
            //{
            //    if (head == null) return null;
            //    List<int> newListSorted = new List<int>();
            //    ListNode newListNodeWithoutDuplicated = new ListNode();
            //    while (head != null)
            //    {
            //        if (!newListSorted.Contains(head.val))
            //        {
            //            newListSorted.Add(head.val);
            //        }
            //        head = head.next;

            //    }

            //    newListSorted.Sort();

            //    for (int i = newListSorted.Count - 1; i >= 0; i--)

            //    {

            //        ListNode newNode = new ListNode(newListSorted[i]);
            //        if (i != newListSorted.Count - 1)
            //            newNode.next = newListNodeWithoutDuplicated;

            //        newListNodeWithoutDuplicated = newNode;



            //    }


            //    return newListNodeWithoutDuplicated;
                #endregion
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
