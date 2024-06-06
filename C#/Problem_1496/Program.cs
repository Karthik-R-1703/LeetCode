using System.Collections.Generic;

namespace Problem_1496
{
    // 1496. Path Crossing
    // https://leetcode.com/problems/path-crossing/description/
    internal class Program
    {
        public static bool IsPathCrossing(string path)
        {
            int cur_x = 0;
            int cur_y = 0;
            List<(int, int)> position = new List<(int, int)>
            {
                (cur_x, cur_y)
            };

            foreach (char direction in path)
            {
                int x = 0;
                int y = 0;
                switch (direction)
                {
                    case 'N':
                        y = 1;
                        break;
                    case 'S':
                        y = -1;
                        break;
                    case 'E':
                        x = 1;
                        break;
                    case 'W':
                        x = -1;
                        break;
                    default:
                        break;
                }

                int new_x = cur_x + x;
                int new_y = cur_y + y;
                if (position.Contains((new_x, new_y)))
                {
                    return true;
                }
                else
                {
                    cur_x = new_x;
                    cur_y = new_y;
                    position.Add((new_x, new_y));
                }
            }

            return false;
        }

        static void Main(string[] args)
        {
            IsPathCrossing("NES");
            IsPathCrossing("NESWW");
        }
    }
}
