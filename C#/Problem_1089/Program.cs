namespace Problem_1089
{
    // 1089. Duplicate Zeros
    // https://leetcode.com/problems/duplicate-zeros/
    internal class Program
    {
        public static void DuplicateZeros(int[] arr)
        {
            int zeros = 0;
            int length = arr.Length - 1;

            for (int i = 0; i <= length - zeros; i++)
            {
                if (arr[i] == 0)
                {
                    if (i == length - zeros)
                    {
                        arr[length] = 0;
                        length -= 1;
                        break;
                    }

                    zeros++;
                }
            }

            int last = length - zeros;
            for (int j = last; j >= 0; j--)
            {
                if (arr[j] == 0)
                {
                    arr[j + zeros] = 0;
                    zeros--;
                    arr[j + zeros] = 0;
                }
                else
                {
                    arr[j + zeros] = arr[j];
                }
            }
        }

        static void Main(string[] args)
        {
            int[] arr1 = { 1, 0, 2, 3, 0, 4, 5, 0 };
            DuplicateZeros(arr1);

            int[] arr2 = { 1, 2, 3 };
            DuplicateZeros(arr2);

            int[] arr3 = { 0, 0, 0, 0, 0, 0, 0 };
            DuplicateZeros(arr3);

            int[] arr4 = { 9, 9, 9, 4, 8, 0, 0, 3, 7, 2, 0, 0, 0, 0, 9, 1, 0, 0, 1, 1, 0, 5, 6, 3, 1, 6, 0, 0, 2, 3, 4, 7, 0, 3, 9, 3, 6, 5, 8, 9, 1, 1, 3, 2, 0, 0, 7, 3, 3, 0, 5, 7, 0, 8, 1, 9, 6, 3, 0, 8, 8, 8, 8, 0, 0, 5, 0, 0, 0, 3, 7, 7, 7, 7, 5, 1, 0, 0, 8, 0, 0 };
            DuplicateZeros(arr4);
        }
    }
}
