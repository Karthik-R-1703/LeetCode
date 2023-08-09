namespace Problem_2043
{
    public class Bank
    {
        public long[] Balances;

        public Bank(long[] balance)
        {
            Balances = balance;
        }

        public bool Transfer(int account1, int account2, long money)
        {
            int Length = Balances.Length;
            if (account1 <= Length && account2 <= Length)
            {
                if (Balances[account1 - 1] >= money)
                {
                    Balances[account1 - 1] -= money;
                    Balances[account2 - 1] += money;
                    return true;
                }
            }

            return false;
        }

        public bool Deposit(int account, long money)
        {
            int Length = Balances.Length;
            if (account <= Balances.Length)
            {
                Balances[account - 1] += money;
                return true;
            }

            return false;
        }

        public bool Withdraw(int account, long money)
        {
            int Length = Balances.Length;
            if (account <= Balances.Length)
            {
                if (Balances[account - 1] >= money)
                {
                    Balances[account - 1] -= money;
                    return true;
                }
            }

            return false;
        }
    }

    /**
     * Your Bank object will be instantiated and called as such:
     * Bank obj = new Bank(balance);
     * bool param_1 = obj.Transfer(account1,account2,money);
     * bool param_2 = obj.Deposit(account,money);
     * bool param_3 = obj.Withdraw(account,money);
     */

    // 2043. Simple Bank System
    // https://leetcode.com/problems/simple-bank-system/
    internal class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank(new long[] { 10, 100, 20, 50, 30 });
            bank.Withdraw(3, 10);    // return true, account 3 has a balance of $20, so it is valid to withdraw $10.
                                     // Account 3 has $20 - $10 = $10.
            bank.Transfer(5, 1, 20); // return true, account 5 has a balance of $30, so it is valid to transfer $20.
                                     // Account 5 has $30 - $20 = $10, and account 1 has $10 + $20 = $30.
            bank.Deposit(5, 20);     // return true, it is valid to deposit $20 to account 5.
                                     // Account 5 has $10 + $20 = $30.
            bank.Transfer(3, 4, 15); // return false, the current balance of account 3 is $10,
                                     // so it is invalid to transfer $15 from it.
            bank.Withdraw(10, 50);   // return false, it is invalid because account 10 does not exist.
        }
    }
}
