namespace Problem_2241
{
    public class ATM
    {
        int[] BankNotes;

        long[] BankNotesCount;

        public ATM()
        {
            BankNotes = new int[] { 20, 50, 100, 200, 500 };
            BankNotesCount = new long[5];
        }

        public void Deposit(int[] banknotesCount)
        {
            for (int i = 0; i < 5; i++)
            {
                BankNotesCount[i] += banknotesCount[i];
            }
        }

        public long[] Withdraw(long amount)
        {
            long[] tmpBankNotes = (long[])BankNotesCount.Clone();
            long[] resultBankNotes = new long[5];

            for (int i = 4; i >= 0; i--)
            {
                if (tmpBankNotes[i] > 0)
                {
                    long Count = amount / BankNotes[i];
                    if (Count <= tmpBankNotes[i])
                    {
                        resultBankNotes[i] = Count;
                        amount -= (Count * BankNotes[i]);
                        tmpBankNotes[i] -= Count;
                    }
                    else
                    {
                        resultBankNotes[i] = tmpBankNotes[i];
                        amount -= (tmpBankNotes[i] * BankNotes[i]);
                        tmpBankNotes[i] = 0;
                    }
                }
            }

            if (amount == 0)
            {
                BankNotesCount = tmpBankNotes;
                return resultBankNotes;
            }
            else
            {
                return new long[] { -1 };
            }
        }
    }

    /**
     * Your ATM object will be instantiated and called as such:
     * ATM obj = new ATM();
     * obj.Deposit(banknotesCount);
     * int[] param_2 = obj.Withdraw(amount);
     */

    // 2241. Design an ATM Machine
    // https://leetcode.com/problems/design-an-atm-machine/
    internal class Program
    {
        static void Main(string[] args)
        {
            ATM atm = new ATM();
            atm.Deposit(new int[] { 0, 0, 1, 2, 1 });   // Deposits 1 $100 banknote, 2 $200 banknotes,
                                                        // and 1 $500 banknote.
            atm.Withdraw(600);                          // Returns [0,0,1,0,1]. The machine uses 1 $100 banknote
                                                        // and 1 $500 banknote. The banknotes left over in the
                                                        // machine are [0,0,0,2,0].
            atm.Deposit(new int[] { 0, 1, 0, 1, 1 });   // Deposits 1 $50, $200, and $500 banknote.
                                                        // The banknotes in the machine are now [0,1,0,3,1].
            atm.Withdraw(600);                          // Returns [-1]. The machine will try to use a $500 banknote
                                                        // and then be unable to complete the remaining $100,
                                                        // so the withdraw request will be rejected.
                                                        // Since the request is rejected, the number of banknotes
                                                        // in the machine is not modified.
            atm.Withdraw(550);                          // Returns [0,1,0,0,1]. The machine uses 1 $50 banknote
                                                        // and 1 $500 banknote.
        }
    }
}
