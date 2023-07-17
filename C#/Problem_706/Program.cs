using System.Collections.Generic;

namespace Problem_706
{
    public class MyHashMap
    {
        public Dictionary<int, int> map;

        public MyHashMap()
        {
            map = new Dictionary<int, int>();
        }

        public void Put(int key, int value)
        {
            if (map.ContainsKey(key))
                map[key] = value;
            else
                map.Add(key, value);
        }

        public int Get(int key)
        {
            if (map.ContainsKey(key))
                return map[key];
            else
                return -1;
        }

        public void Remove(int key)
        {
            map.Remove(key);
        }
    }

    /**
     * Your MyHashMap object will be instantiated and called as such:
     * MyHashMap obj = new MyHashMap();
     * obj.Put(key,value);
     * int param_2 = obj.Get(key);
     * obj.Remove(key);
     */

    // 706. Design HashMap
    // https://leetcode.com/problems/design-hashmap/
    internal class Program
    {
        static void Main(string[] args)
        {
            MyHashMap myHashMap = new MyHashMap();
            myHashMap.Put(1, 1); // The map is now [[1,1]]
            myHashMap.Put(2, 2); // The map is now [[1,1], [2,2]]
            myHashMap.Get(1);    // return 1, The map is now [[1,1], [2,2]]
            myHashMap.Get(3);    // return -1 (i.e., not found), The map is now [[1,1], [2,2]]
            myHashMap.Put(2, 1); // The map is now [[1,1], [2,1]] (i.e., update the existing value)
            myHashMap.Get(2);    // return 1, The map is now [[1,1], [2,1]]
            myHashMap.Remove(2); // remove the mapping for 2, The map is now [[1,1]]
            myHashMap.Get(2);    // return -1 (i.e., not found), The map is now [[1,1]]
        }
    }
}
