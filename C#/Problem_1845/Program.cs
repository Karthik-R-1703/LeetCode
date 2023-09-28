using System.Collections.Generic;
using System.Linq;

namespace Problem_1845
{
    // 1845. Seat Reservation Manager
    // https://leetcode.com/problems/seat-reservation-manager/description/
    internal class Program
    {
        static void Main(string[] args)
        {
            SeatManager seatManager = new SeatManager(5); // Initializes a SeatManager with 5 seats.
            seatManager.Reserve();    // All seats are available, so return the lowest numbered seat, which is 1.
            seatManager.Reserve();    // The available seats are [2,3,4,5], so return the lowest of them, which is 2.
            seatManager.Unreserve(2); // Unreserve seat 2, so now the available seats are [2,3,4,5].
            seatManager.Reserve();    // The available seats are [2,3,4,5], so return the lowest of them, which is 2.
            seatManager.Reserve();    // The available seats are [3,4,5], so return the lowest of them, which is 3.
            seatManager.Reserve();    // The available seats are [4,5], so return the lowest of them, which is 4.
            seatManager.Reserve();    // The only available seat is seat 5, so return 5.
            seatManager.Unreserve(5); // Unreserve seat 5, so now the available seats are [5].
        }
    }

    public class SeatManager
    {
        public HashSet<int> Reserved;
        public SortedSet<int> UnReserved;

        public SeatManager(int n)
        {
            Reserved = new HashSet<int>();
            UnReserved = new SortedSet<int>();
            for (int i = 1; i <= n; i++)
            {
                UnReserved.Add(i);
            }
        }

        public int Reserve()
        {
            int seat = UnReserved.First();
            UnReserved.Remove(seat);
            Reserved.Add(seat);
            return seat;
        }

        public void Unreserve(int seatNumber)
        {
            Reserved.Remove(seatNumber);
            UnReserved.Add(seatNumber);
        }
    }

    /**
     * Your SeatManager object will be instantiated and called as such:
     * SeatManager obj = new SeatManager(n);
     * int param_1 = obj.Reserve();
     * obj.Unreserve(seatNumber);
     */
}
