namespace Problem_1861
{
    // 1861. Rotating the Box
    // https://leetcode.com/problems/rotating-the-box/description/
    internal class Program
    {
        static void Main(string[] args)
        {
            char[][] box1 = new char[][]
            {
                new char[] { '#', '.', '#' }
            };

            RotateTheBox(box1);

            char[][] box2 = new char[][]
            {
                new char[] { '#', '.', '*', '.' },
                new char[] { '#', '#', '*', '.' }
            };

            RotateTheBox(box2);
        }

        public static char[][] RotateTheBox(char[][] box)
        {
            int m = box.Length;
            int n = box[0].Length;
            char[][] rotatedBox = new char[n][];
            for (int i = 0; i < n; i++)
            {
                rotatedBox[i] = new char[m];
                for (int j = 0; j < m; j++)
                {
                    rotatedBox[i][j] = '.';
                }
            }

            for (int i = 0; i < m; i++)
            {
                int emptyIndex = n - 1;
                for (int j = n - 1; j >= 0; j--)
                {
                    if (box[i][j] == '#')
                    {
                        rotatedBox[emptyIndex][m - i - 1] = '#';
                        emptyIndex--;
                    }
                    else if (box[i][j] == '*')
                    {
                        rotatedBox[j][m - i - 1] = '*';
                        emptyIndex = j - 1;
                    }
                }
            }

            return rotatedBox;
        }
    }
}
