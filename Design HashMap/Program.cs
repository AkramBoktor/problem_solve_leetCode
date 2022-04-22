using System;
using System.Collections.Generic;

namespace Design_HashMap
{
    class Program
    {
        static void Main(string[] args)
        {
            MyHashMap hashMap = new MyHashMap();
            hashMap.Put(1, 1);
            hashMap.Put(2, 2);
            hashMap.ShowData(hashMap.myHashMapDictionary);
            hashMap.Put(1, 3);
            hashMap.ShowData(hashMap.myHashMapDictionary);
            hashMap.Remove(2);
            hashMap.ShowData(hashMap.myHashMapDictionary);


        }

        public class MyHashMap
        {
            public Dictionary<int, int> myHashMapDictionary;

            public MyHashMap()
            {
                myHashMapDictionary = new Dictionary<int, int>();
            }

            public void Put(int key, int value)
            {
                if (myHashMapDictionary.ContainsKey(key))
                    myHashMapDictionary[key] = value;

                else
                    myHashMapDictionary.Add(key, value);
            }

            public int Get(int key)
            {
                return myHashMapDictionary.ContainsKey(key) ? myHashMapDictionary[key] : -1;

            }

            public void Remove(int key)
            {
                if (Get(key) != -1) myHashMapDictionary.Remove(key);
            }

            public void ShowData(Dictionary<int,int> DictionaryHashMap)
            {
                Console.WriteLine(string.Join(",", DictionaryHashMap));
            }

        }
     }
}
