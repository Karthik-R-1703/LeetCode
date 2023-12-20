using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_2353
{
    // 2353. Design a Food Rating System
    // https://leetcode.com/problems/design-a-food-rating-system/description/

    public class FoodRatings
    {
        Dictionary<string, Dictionary<string, int>> Cuisines = new Dictionary<string, Dictionary<string, int>>();

        public FoodRatings(string[] foods, string[] cuisines, int[] ratings)
        {
            for (int i = 0; i < foods.Length; i++)
            {
                if (Cuisines.ContainsKey(cuisines[i]))
                {
                    Cuisines[cuisines[i]].Add(foods[i], ratings[i]);
                }
                else
                {
                    Cuisines.Add(cuisines[i], new Dictionary<string, int>() { { foods[i], ratings[i] } });
                }
            }
        }

        public void ChangeRating(string food, int newRating)
        {
            for (int i = 0; i < Cuisines.Count; i++)
            {
                if (Cuisines.ElementAt(i).Value.ContainsKey(food))
                {
                    Cuisines.ElementAt(i).Value[food] = newRating;
                    break;
                }
            }
        }

        public string HighestRated(string cuisine)
        {
            string[] Foods = Cuisines[cuisine].Where(x => x.Value == Cuisines[cuisine].Values.Max()).Select(x => x.Key).ToArray();
            Array.Sort(Foods);
            return Foods[0];
        }
    }

    /**
     * Your FoodRatings object will be instantiated and called as such:
     * FoodRatings obj = new FoodRatings(foods, cuisines, ratings);
     * obj.ChangeRating(food,newRating);
     * string param_2 = obj.HighestRated(cuisine);
     */

    internal class Program
    {
        static void Main(string[] args)
        {
            FoodRatings foodRatings = new FoodRatings(new string[] { "kimchi", "miso", "sushi", "moussaka", "ramen", "bulgogi" }, new string[] { "korean", "japanese", "japanese", "greek", "japanese", "korean" }, new int[] { 9, 12, 8, 15, 14, 7 });
            foodRatings.HighestRated("korean");     // return "kimchi"
                                                    // "kimchi" is the highest rated korean food with a rating of 9.
            foodRatings.HighestRated("japanese");   // return "ramen"
                                                    // "ramen" is the highest rated japanese food with a rating of 14.
            foodRatings.ChangeRating("sushi", 16);  // "sushi" now has a rating of 16.
            foodRatings.HighestRated("japanese");   // return "sushi"
                                                    // "sushi" is the highest rated japanese food with a rating of 16.
            foodRatings.ChangeRating("ramen", 16);  // "ramen" now has a rating of 16.
            foodRatings.HighestRated("japanese");   // return "ramen"
                                                    // Both "sushi" and "ramen" have a rating of 16.
                                                    // However, "ramen" is lexicographically smaller than "sushi".
        }
    }
}
