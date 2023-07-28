namespace Problem_852
{
    // 852. Peak Index in a Mountain Array
    // https://leetcode.com/problems/peak-index-in-a-mountain-array/
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 0, 1, 0 };
            PeakIndexInMountainArray(arr1);

            int[] arr2 = { 0, 2, 1, 0 };
            PeakIndexInMountainArray(arr2);

            int[] arr3 = { 0, 10, 5, 2 };
            PeakIndexInMountainArray(arr3);
        }

        public static int PeakIndexInMountainArray(int[] arr)
        {
            int start = 0;
            int end = arr.Length;
            int index = (start + end) / 2;
            while (index > 0 && index < arr.Length - 1)
            {
                if (arr[index - 1] < arr[index] && arr[index] > arr[index + 1])
                    return index;
                else if (arr[index - 1] > arr[index])
                {
                    end = index;
                    index = (start + end) / 2;
                }
                else
                {
                    start = index;
                    index = (start + end) / 2;
                }
            }

            return index;
        }
    }
}
