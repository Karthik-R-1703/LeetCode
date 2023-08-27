namespace Problem_8015
{
    // 8015. Furthest Point From Origin
    // 2833. Furthest Point From Origin
    // https://leetcode.com/problems/furthest-point-from-origin/
    internal class Program
    {
        public int FurthestDistanceFromOrigin(string moves)
        {
            int distance = 0;
            int L = 0;
            int R = 0;
            int none = 0;
            foreach (char move in moves)
            {
                switch (move)
                {
                    case 'L':
                        L++;
                        break;
                    case 'R':
                        R++;
                        break;
                    default:
                        none++;
                        break;
                }
            }

            if (L >= R)
            {
                distance = L - R;
            }
            else
            {
                distance = R - L;
            }

            distance += none;
            return distance;
        }

        static void Main(string[] args)
        {
        }
    }
}
