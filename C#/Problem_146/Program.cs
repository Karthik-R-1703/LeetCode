using System.Collections.Generic;
using System.Linq;

namespace Problem_146
{
    public class LRUCache
    {
        public Dictionary<int, int> Cache;

        public List<int> LRU;

        public int CacheCapacity;

        public LRUCache(int capacity)
        {
            Cache = new Dictionary<int, int>(capacity);
            LRU = new List<int>(capacity);
            CacheCapacity = capacity;
        }

        public int Get(int key)
        {
            if (Cache.ContainsKey(key))
            {
                LRU.Remove(key);
                LRU.Add(key);
                return Cache[key];
            }
            else
            {
                return -1;
            }
        }

        public void Put(int key, int value)
        {
            if (Cache.ContainsKey(key))
            {
                Cache[key] = value;
                LRU.Remove(key);
                LRU.Add(key);
            }
            else
            {
                if (Cache.Count == CacheCapacity)
                {
                    int oldKey = LRU.First();
                    Cache.Remove(oldKey);
                    LRU.Remove(oldKey);
                }

                Cache.Add(key, value);
                LRU.Add(key);
            }
        }
    }

    /**
     * Your LRUCache object will be instantiated and called as such:
     * LRUCache obj = new LRUCache(capacity);
     * int param_1 = obj.Get(key);
     * obj.Put(key,value);
     */

    // 146. LRU Cache
    // https://leetcode.com/problems/lru-cache/
    internal class Program
    {
        static void Main(string[] args)
        {
            LRUCache lRUCache = new LRUCache(2);
            lRUCache.Put(1, 1); // cache is {1=1}
            lRUCache.Put(2, 2); // cache is {1=1, 2=2}
            lRUCache.Get(1);    // return 1
            lRUCache.Put(3, 3); // LRU key was 2, evicts key 2, cache is {1=1, 3=3}
            lRUCache.Get(2);    // returns -1 (not found)
            lRUCache.Put(4, 4); // LRU key was 1, evicts key 1, cache is {4=4, 3=3}
            lRUCache.Get(1);    // return -1 (not found)
            lRUCache.Get(3);    // return 3
            lRUCache.Get(4);    // return 4
        }
    }
}
