using System;

namespace BankAccount
{
    internal class Enum
    {
        public enum AccountType
        {
            Checking,
            Deposit
        }

        static void Main(string[] args)
        {
            AccountType goldAccount = AccountType.Checking;
            AccountType platinumAccount = AccountType.Deposit;

            Console.WriteLine("The customer Account Type is {0}", goldAccount);
            Console.WriteLine("The customer Account Type is {0}", platinumAccount);
        }
    }
}
