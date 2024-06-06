namespace Problem_1287
{
    // 1287. Element Appearing More Than 25% In Sorted Array
    // https://leetcode.com/problems/element-appearing-more-than-25-in-sorted-array/description/
    internal class Program
    {
        public static int FindSpecialInteger(int[] arr)
        {
            int n = arr.Length;
            int s = n / 4;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] == arr[i + s])
                    return arr[i];
            }

            return 0;
        }

        static void Main(string[] args)
        {
            FindSpecialInteger(new int[] { 1, 2, 2, 6, 6, 6, 6, 7, 10 });
            FindSpecialInteger(new int[] { 1, 1 });
        }
    }
}
