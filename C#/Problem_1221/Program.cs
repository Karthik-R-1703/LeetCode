namespace Problem_1221
{
    // 1221. Split a String in Balanced Strings
    // https://leetcode.com/problems/split-a-string-in-balanced-strings/description/
    internal class Program
    {
        public static int BalancedStringSplit(string s)
        {
            int count = 0;
            int tmpCount = 0;
            foreach (char c in s)
            {
                if (c == 'L')
                {
                    tmpCount--;
                }
                else
                {
                    tmpCount++;
                }

                if (tmpCount == 0)
                {
                    count++;
                }
            }

            return count;
        }

        static void Main(string[] args)
        {
            BalancedStringSplit("RLRRLLRLRL");
            BalancedStringSplit("RLRRRLLRLL");
            BalancedStringSplit("LLLLRRRR");
        }
    }
}
