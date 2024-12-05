namespace Problem_2337
{
    // 2337. Move Pieces to Obtain a String
    // https://leetcode.com/problems/move-pieces-to-obtain-a-string/description/
    internal class Program
    {
        public static bool CanChange(string start, string target)
        {
            int i = 0, j = 0;
            int s = start.Length, t = target.Length;
            while (i < s || j < t)
            {
                while (i < s && start[i] == '_')
                    i++;

                while (j < t && target[j] == '_')
                    j++;

                if (i == s || j == t)
                    return i == s && j == t;

                if (start[i] != target[j] || (start[i] == 'L' && i < j) || (start[i] == 'R' && i > j))
                    return false;

                i++;
                j++;
            }

            return true;
        }

        static void Main(string[] args)
        {
            CanChange("_L__R__R_", "L______RR");
            CanChange("R_L_", "__LR");
            CanChange("_R", "R_");
        }
    }
}
