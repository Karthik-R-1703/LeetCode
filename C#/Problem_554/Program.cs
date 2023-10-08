using System.Collections.Generic;
using System.Linq;

namespace Problem_554
{
    // 554. Brick Wall
    // https://leetcode.com/problems/brick-wall/description/
    internal class Program
    {
        public static int LeastBricks(IList<IList<int>> wall)
        {
            Dictionary<int, int> rowSum = new Dictionary<int, int>();
            foreach (var row in wall)
            {
                int sum = 0;
                foreach (var brick in row)
                {
                    sum += brick;
                    if (rowSum.ContainsKey(sum))
                        rowSum[sum]++;
                    else
                        rowSum.Add(sum, 1);
                }
            }

            rowSum.Remove(wall[0].Sum());
            if (rowSum.Count > 0)
                return wall.Count - rowSum.Values.Max();
            else
                return wall.Count;
        }

        static void Main(string[] args)
        {
            IList<IList<int>> wall1 = new List<IList<int>> {
                new List<int> {1, 2, 2, 1},
                new List<int> {3, 1, 2},
                new List<int> {1, 3, 2},
                new List<int> {2, 4},
                new List<int> {3, 1, 2},
                new List<int> {1, 3, 1, 1}
            };

            LeastBricks(wall1);

            IList<IList<int>> wall2 = new List<IList<int>> {
                new List<int> {1},
                new List<int> {1},
                new List<int> {1}
            };

            LeastBricks(wall2);
        }
    }
}
