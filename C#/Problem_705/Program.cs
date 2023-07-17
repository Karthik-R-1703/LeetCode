using System.Collections.Generic;

namespace Problem_705
{
    public class MyHashSet
    {
        public HashSet<int> Set;

        public MyHashSet()
        {
            Set = new HashSet<int>();
        }

        public void Add(int key)
        {
            Set.Add(key);
        }

        public void Remove(int key)
        {
            Set.Remove(key);
        }

        public bool Contains(int key)
        {
            return Set.Contains(key);
        }
    }

    /**
     * Your MyHashSet object will be instantiated and called as such:
     * MyHashSet obj = new MyHashSet();
     * obj.Add(key);
     * obj.Remove(key);
     * bool param_3 = obj.Contains(key);
     */

    // 705. Design HashSet
    // https://leetcode.com/problems/design-hashset/
    internal class Program
    {
        static void Main(string[] args)
        {
            MyHashSet myHashSet = new MyHashSet();
            myHashSet.Add(1);      // set = [1]
            myHashSet.Add(2);      // set = [1, 2]
            myHashSet.Contains(1); // return True
            myHashSet.Contains(3); // return False, (not found)
            myHashSet.Add(2);      // set = [1, 2]
            myHashSet.Contains(2); // return True
            myHashSet.Remove(2);   // set = [1]
            myHashSet.Contains(2); // return False, (already removed)
        }
    }
}
