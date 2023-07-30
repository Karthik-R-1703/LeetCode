namespace Problem_605
{
    // 605. Can Place Flowers
    // https://leetcode.com/problems/can-place-flowers/
    internal class Program
    {
        public static bool CanPlaceFlowers(int[] flowerbed, int n)
        {
            int count = 0;
            for (int i = 0; i < flowerbed.Length; i++)
            {
                if (flowerbed[i] == 0)
                {
                    bool emptyLeftPlot = (i == 0) || (flowerbed[i - 1] == 0);
                    bool emptyRightPlot = (i == flowerbed.Length - 1) || (flowerbed[i + 1] == 0);

                    if (emptyLeftPlot && emptyRightPlot)
                    {
                        flowerbed[i] = 1;
                        count++;
                        if (count >= n)
                        {
                            return true;
                        }
                    }
                }
            }

            return count >= n;
        }

        static void Main(string[] args)
        {
            int[] flowerbed = { 1, 0, 0, 0, 1 };
            CanPlaceFlowers(flowerbed, 1);
            CanPlaceFlowers(flowerbed, 2);
        }
    }
}
