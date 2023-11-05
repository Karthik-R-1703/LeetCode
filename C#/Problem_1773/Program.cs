using System;
using System.Collections.Generic;

namespace Problem_1773
{
    // 1773. Count Items Matching a Rule
    // https://leetcode.com/problems/count-items-matching-a-rule/description/
    internal class Program
    {
        enum Rule
        {
            type,
            color,
            name
        };

        public static int CountMatches(IList<IList<string>> items, string ruleKey, string ruleValue)
        {
            Enum.TryParse(ruleKey, out Rule rule);
            int RuleIndex = (int)rule;
            int count = 0;
            foreach (var item in items)
            {
                if (item[RuleIndex].Equals(ruleValue))
                {
                    count++;
                }
            }

            return count;
        }

        static void Main(string[] args)
        {
            IList<IList<string>> items1 = new List<IList<string>> {
                new List<string> { "phone", "blue", "pixel" },
                new List<string> { "computer", "silver", "lenovo" },
                new List<string> { "phone", "gold", "iphone" }
            };

            CountMatches(items1, "color", "silver");

            IList<IList<string>> items2 = new List<IList<string>> {
                new List<string> { "phone", "blue", "pixel" },
                new List<string> { "computer", "silver", "phone" },
                new List<string> { "phone", "gold", "iphone" }
            };

            CountMatches(items2, "type", "phone");
        }
    }
}
