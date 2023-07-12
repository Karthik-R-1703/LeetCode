namespace Problem_752
{
    // 752. Open the Lock
    // https://leetcode.com/problems/open-the-lock/
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] deadends1 = { "0201", "0101", "0102", "1212", "2002" };
            OpenLock(deadends1, "0202");

            string[] deadends2 = { "8888" };
            OpenLock(deadends2, "0009");

            string[] deadends3 = { "8887", "8889", "8878", "8898", "8788", "8988", "7888", "9888" };
            OpenLock(deadends3, "8888");
        }

        public static int OpenLock(string[] deadends, string target)
        {
            int turns = -1;
            return turns;
        }
    }
}
