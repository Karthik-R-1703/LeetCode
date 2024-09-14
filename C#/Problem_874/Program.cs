using System.Collections.Generic;

namespace Problem_874
{
    // 874. Walking Robot Simulation
    // https://leetcode.com/problems/walking-robot-simulation/description/
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] commands = new int[] { 4, -1, 3 };
            int[][] obstacles = new int[][]
            {
            };

            RobotSim(commands, obstacles);

            int[] commands_2 = new int[] { 4, -1, 4, -2, 4 };
            int[][] obstacles_2 = new int[][]
            {
                new int[] { 2, 4 }
            };

            RobotSim(commands_2, obstacles_2);

            int[] commands_3 = new int[] { 6, -1, -1, 6 };
            int[][] obstacles_3 = new int[][]
            {
            };

            RobotSim(commands_3, obstacles_3);

            int[] commands_4 = new int[] { 1, -1, 1, -1, 1, -1, 6 };
            int[][] obstacles_4 = new int[][]
            {
                new int[] { 0, 0 }
            };

            RobotSim(commands_4, obstacles_4);
        }

        public static int RobotSim(int[] commands, int[][] obstacles)
        {
            int maxDistance = 0;
            (int x, int y) point = (0, 0);
            (int x, int y) direction = (0, 1);
            HashSet<(int x, int y)> Obs = new HashSet<(int x, int y)>();
            for (int i = 0; i < obstacles.Length; i++)
            {
                Obs.Add((obstacles[i][0], obstacles[i][1]));
            }

            foreach (int command in commands)
            {
                if (command == -2)
                {
                    direction = (-direction.y, direction.x);
                }
                else if (command == -1)
                {
                    direction = (direction.y, -direction.x);
                }
                else
                {
                    int c = command;
                    while (c-- > 0 && !Obs.Contains((point.x + direction.x, point.y + direction.y)))
                        point = (point.x + direction.x, point.y + direction.y);

                    int distance = point.x * point.x + point.y * point.y;
                    if (distance > maxDistance)
                        maxDistance = distance;
                }
            }

            return maxDistance;
        }
    }
}