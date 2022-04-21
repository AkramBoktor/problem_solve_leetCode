using System;
using System.Collections.Generic;

namespace Design_Hasing_Set
{
    class Program
    {
        static void Main(string[] args)
        {
            MyHashSet myHashSet = new MyHashSet();
            myHashSet.Add(1);
            myHashSet.Add(2);
            myHashSet.Contains(1);
            myHashSet.Contains(3);
            myHashSet.Remove(2);

           myHashSet.ShowData(myHashSet.myHashSetList);
        }

        public class MyHashSet
        {
            public List<int> myHashSetList;

            public MyHashSet()
            {
                myHashSetList = new List<int>();
            }

            public void Add(int key)
            {
                if (!Contains(key)) myHashSetList.Add(key);
            }

            public void Remove(int key)
            {
                if (Contains(key)) myHashSetList.Remove(key);

            }

            public bool Contains(int key)
            {
                return myHashSetList.Contains(key) ? true : false;
            }

            public void ShowData(List<int> myHashSetList)
            {
                Console.WriteLine(string.Join(",", myHashSetList));
            }
        }
    }
}
