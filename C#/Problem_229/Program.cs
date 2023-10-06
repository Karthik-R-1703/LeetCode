using System.Collections.Generic;
using System.Linq;

namespace Problem_229
{
    // 229. Majority Element II
    // https://leetcode.com/problems/majority-element-ii/description/
    internal class Program
    {
        static void Main(string[] args)
        {
            MajorityElement(new int[] { 3, 2, 3 });
            MajorityElement(new int[] { 1 });
            MajorityElement(new int[] { 1, 2 });
        }

        public static IList<int> MajorityElement(int[] nums)
        {
            int targetCount = nums.Length / 3;
            return nums.GroupBy(num => num).Where(group => group.Count() > targetCount).Select(group => group.Key).ToList();
        }
    }
}
