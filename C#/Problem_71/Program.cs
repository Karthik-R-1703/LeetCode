using System;
using System.Collections.Generic;

namespace Problem_71
{
    // 71. Simplify Path
    // https://leetcode.com/problems/simplify-path/
    internal class Program
    {
        public static string SimplifyPath(string path)
        {
            string[] subPaths = path.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
            List<string> result = new List<string>();
            foreach (string subPath in subPaths)
            {
                if (subPath.Equals(".."))
                {
                    if (result.Count > 0)
                    {
                        result.RemoveAt(result.Count - 1);
                    }
                }
                else if (subPath.Equals("."))
                {

                }
                else
                {
                    result.Add(subPath);
                }
            }

            return "/" + string.Join("/", result.ToArray());
        }

        static void Main(string[] args)
        {
            string simplifiedPath;

            simplifiedPath = SimplifyPath("/home/");
            simplifiedPath = SimplifyPath("/../");
            simplifiedPath = SimplifyPath("/home//foo/");
            simplifiedPath = SimplifyPath("/a/./b/../../c/");
        }
    }
}
