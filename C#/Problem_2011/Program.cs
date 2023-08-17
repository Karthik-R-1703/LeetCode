namespace Problem_2011
{
    // 2011. Final Value of Variable After Performing Operations
    // https://leetcode.com/problems/final-value-of-variable-after-performing-operations/
    internal class Program
    {
        public int FinalValueAfterOperations(string[] operations)
        {
            int X = 0;
            foreach (string operation in operations)
            {
                if (operation == "++X" || operation == "X++")
                {
                    X++;
                }
                else
                {
                    X--;
                }
            }

            return X;
        }

        static void Main(string[] args)
        {
        }
    }
}
