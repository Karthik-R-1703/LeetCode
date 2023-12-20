namespace Problem_661
{
    // 661. Image Smoother
    // https://leetcode.com/problems/image-smoother/description/
    internal class Program
    {
        public static int[][] ImageSmoother(int[][] img)
        {
            int m = img.Length;
            int n = img[0].Length;
            int[][] image = new int[m][];
            for (int i = 0; i < m; i++)
                image[i] = new int[n];

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    int numerator = 0;
                    int denominator = 0;
                    if (i - 1 >= 0 && j - 1 >= 0)
                    {
                        numerator += img[i - 1][j - 1];
                        denominator++;
                    }

                    if (i - 1 >= 0)
                    {
                        numerator += img[i - 1][j];
                        denominator++;
                    }

                    if (i - 1 >= 0 && j + 1 < n)
                    {
                        numerator += img[i - 1][j + 1];
                        denominator++;
                    }

                    if (j - 1 >= 0)
                    {
                        numerator += img[i][j - 1];
                        denominator++;
                    }

                    numerator += img[i][j];
                    denominator++;

                    if (j + 1 < n)
                    {
                        numerator += img[i][j + 1];
                        denominator++;
                    }

                    if (i + 1 < m && j - 1 >= 0)
                    {
                        numerator += img[i + 1][j - 1];
                        denominator++;
                    }

                    if (i + 1 < m)
                    {
                        numerator += img[i + 1][j];
                        denominator++;
                    }

                    if (i + 1 < m && j + 1 < n)
                    {
                        numerator += img[i + 1][j + 1];
                        denominator++;
                    }

                    image[i][j] = numerator / denominator;
                }
            }

            return image;
        }

        static void Main(string[] args)
        {
            int[][] img1 =
            {
                new int[] { 1, 1, 1 },
                new int[] { 1, 0, 1 },
                new int[] { 1, 1, 1 }
            };

            ImageSmoother(img1);

            int[][] img2 =
            {
                new int[] { 100, 200, 100 },
                new int[] { 200, 50, 200 },
                new int[] { 100, 200, 100 }
            };

            ImageSmoother(img2);

            int[][] img3 =
            {
                new int[] { 2, 3, 4 },
                new int[] { 5, 6, 7 },
                new int[] { 8, 9, 10 },
                new int[] { 11, 12, 13 },
                new int[] { 14, 15, 16 }
            };

            ImageSmoother(img3);
        }
    }
}
