namespace Problem_1476
{
    // 1476. Subrectangle Queries
    // https://leetcode.com/problems/subrectangle-queries/description/
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] rectangle1 = new int[][]
            {
                new int[] {1, 2, 1},
                new int[] {4, 3, 4},
                new int[] {3, 2, 1},
                new int[] {1, 1, 1}
            };

            SubrectangleQueries subrectangleQueries = new SubrectangleQueries(rectangle1);
            // The initial rectangle (4x3) looks like:
            // 1 2 1
            // 4 3 4
            // 3 2 1
            // 1 1 1
            subrectangleQueries.GetValue(0, 2); // return 1
            subrectangleQueries.UpdateSubrectangle(0, 0, 3, 2, 5);
            // After this update the rectangle looks like:
            // 5 5 5
            // 5 5 5
            // 5 5 5
            // 5 5 5 
            subrectangleQueries.GetValue(0, 2); // return 5
            subrectangleQueries.GetValue(3, 1); // return 5
            subrectangleQueries.UpdateSubrectangle(3, 0, 3, 2, 10);
            // After this update the rectangle looks like:
            // 5   5   5
            // 5   5   5
            // 5   5   5
            // 10  10  10 
            subrectangleQueries.GetValue(3, 1); // return 10
            subrectangleQueries.GetValue(0, 2); // return 5

            int[][] rectangle2 = new int[][]
            {
                new int[] {1, 1, 1},
                new int[] {2, 2, 2},
                new int[] {3, 3, 3}
            };

            subrectangleQueries = new SubrectangleQueries(rectangle2);
            subrectangleQueries.GetValue(0, 0); // return 1
            subrectangleQueries.UpdateSubrectangle(0, 0, 2, 2, 100);
            subrectangleQueries.GetValue(0, 0); // return 100
            subrectangleQueries.GetValue(2, 2); // return 100
            subrectangleQueries.UpdateSubrectangle(1, 1, 2, 2, 20);
            subrectangleQueries.GetValue(2, 2); // return 20
        }
    }

    public class SubrectangleQueries
    {
        public int[][] Rectangle;

        public SubrectangleQueries(int[][] rectangle)
        {
            Rectangle = rectangle;
        }

        public void UpdateSubrectangle(int row1, int col1, int row2, int col2, int newValue)
        {
            for (int i = row1; i <= row2; i++)
            {
                for (int j = col1; j <= col2; j++)
                    Rectangle[i][j] = newValue;
            }
        }

        public int GetValue(int row, int col)
        {
            return Rectangle[row][col];
        }
    }

    /**
     * Your SubrectangleQueries object will be instantiated and called as such:
     * SubrectangleQueries obj = new SubrectangleQueries(rectangle);
     * obj.UpdateSubrectangle(row1,col1,row2,col2,newValue);
     * int param_2 = obj.GetValue(row,col);
     */
}
