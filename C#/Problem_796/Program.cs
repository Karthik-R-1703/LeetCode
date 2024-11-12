namespace Problem_796
{
    // 796. Rotate String
    // https://leetcode.com/problems/rotate-string/description/
    internal class Program
    {
        static void Main(string[] args)
        {
        }

        public static bool RotateString(string s, string goal)
        {
            if (s.Length != goal.Length)
                return false;

            s += s;
            if (s.Contains(goal))
                return true;

            return false;
        }
    }
}
