using System.Collections.Generic;
using System.Linq;

namespace Problem_1396
{
    // 1396. Design Underground System
    // https://leetcode.com/problems/design-underground-system/description/
    internal class Program
    {
        static void Main(string[] args)
        {
            UndergroundSystem undergroundSystem = new UndergroundSystem();
            undergroundSystem.CheckIn(45, "Leyton", 3);
            undergroundSystem.CheckIn(32, "Paradise", 8);
            undergroundSystem.CheckIn(27, "Leyton", 10);
            undergroundSystem.CheckOut(45, "Waterloo", 15);  // Customer 45 "Leyton" -> "Waterloo" in 15-3 = 12
            undergroundSystem.CheckOut(27, "Waterloo", 20);  // Customer 27 "Leyton" -> "Waterloo" in 20-10 = 10
            undergroundSystem.CheckOut(32, "Cambridge", 22); // Customer 32 "Paradise" -> "Cambridge" in 22-8 = 14
            undergroundSystem.GetAverageTime("Paradise", "Cambridge"); // return 14.00000. One trip "Paradise" -> "Cambridge", (14) / 1 = 14
            undergroundSystem.GetAverageTime("Leyton", "Waterloo");    // return 11.00000. Two trips "Leyton" -> "Waterloo", (10 + 12) / 2 = 11
            undergroundSystem.CheckIn(10, "Leyton", 24);
            undergroundSystem.GetAverageTime("Leyton", "Waterloo");    // return 11.00000
            undergroundSystem.CheckOut(10, "Waterloo", 38);  // Customer 10 "Leyton" -> "Waterloo" in 38-24 = 14
            undergroundSystem.GetAverageTime("Leyton", "Waterloo");    // return 12.00000. Three trips "Leyton" -> "Waterloo", (10 + 12 + 14) / 3 = 12

            undergroundSystem = new UndergroundSystem();
            undergroundSystem.CheckIn(10, "Leyton", 3);
            undergroundSystem.CheckOut(10, "Paradise", 8); // Customer 10 "Leyton" -> "Paradise" in 8-3 = 5
            undergroundSystem.GetAverageTime("Leyton", "Paradise"); // return 5.00000, (5) / 1 = 5
            undergroundSystem.CheckIn(5, "Leyton", 10);
            undergroundSystem.CheckOut(5, "Paradise", 16); // Customer 5 "Leyton" -> "Paradise" in 16-10 = 6
            undergroundSystem.GetAverageTime("Leyton", "Paradise"); // return 5.50000, (5 + 6) / 2 = 5.5
            undergroundSystem.CheckIn(2, "Leyton", 21);
            undergroundSystem.CheckOut(2, "Paradise", 30); // Customer 2 "Leyton" -> "Paradise" in 30-21 = 9
            undergroundSystem.GetAverageTime("Leyton", "Paradise"); // return 6.66667, (5 + 6 + 9) / 3 = 6.66667
        }
    }

    public class UndergroundSystem
    {
        public Dictionary<int, (string, int)> CheckInData;

        public Dictionary<(string, string), List<int>> Times;

        public UndergroundSystem()
        {
            CheckInData = new Dictionary<int, (string, int)>();
            Times = new Dictionary<(string, string), List<int>>();
        }

        public void CheckIn(int id, string stationName, int t)
        {
            CheckInData.Add(id, (stationName, t));
        }

        public void CheckOut(int id, string stationName, int t)
        {
            (string, int) data = CheckInData[id];
            if (Times.ContainsKey((data.Item1, stationName)))
            {
                Times[(data.Item1, stationName)].Add(t - data.Item2);
            }
            else
            {
                Times.Add((data.Item1, stationName), new List<int> { t - data.Item2 });
            }

            CheckInData.Remove(id);
        }

        public double GetAverageTime(string startStation, string endStation)
        {
            return Times[(startStation, endStation)].Average();
        }
    }

    /**
     * Your UndergroundSystem object will be instantiated and called as such:
     * UndergroundSystem obj = new UndergroundSystem();
     * obj.CheckIn(id,stationName,t);
     * obj.CheckOut(id,stationName,t);
     * double param_3 = obj.GetAverageTime(startStation,endStation);
     */
}
