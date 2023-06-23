namespace Problem_1295
{
    // 1295. Find Numbers with Even Number of Digits
    // https://leetcode.com/problems/find-numbers-with-even-number-of-digits/
    internal class Program
    {
        public static int FindNumbers(int[] nums)
        {
            int count = 0;

            foreach (int num in nums)
            {
                if (IsEvenNumDigits(num))
                {
                    count++;
                }
            }

            return count;
        }

        public static bool IsEvenNumDigits(int num)
        {
            int count = 0;
            while (num > 0)
            {
                count++;
                num /= 10;
            }

            return count % 2 == 0;
        }

        static void Main(string[] args)
        {
            int[] nums1 = { 12, 345, 2, 6, 7896 };
            FindNumbers(nums1);

            int[] nums2 = { 555, 901, 482, 1771 };
            FindNumbers(nums2);
        }
    }
}
