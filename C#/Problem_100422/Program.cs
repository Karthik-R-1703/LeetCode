using System;

namespace Problem_100422
{
    // 100422. Convert Date to Binary
    // 3280. Convert Date to Binary
    // https://leetcode.com/problems/convert-date-to-binary/description/
    internal class Program
    {
        public string ConvertDateToBinary(string date)
        {
            string[] binaryDate = new string[3];
            string[] nums = date.Split(new char[] { '-' });
            for (int i = 0; i < nums.Length; i++)
            {
                int x = Convert.ToInt32(nums[i]);
                binaryDate[i] = Convert.ToString(x, 2);
            }

            return String.Join("-", binaryDate);
        }

        static void Main(string[] args)
        {
        }
    }
}
