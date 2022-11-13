using System;

namespace StructType
{
    internal class Struct
    {

        public enum AccountType
        {
            Checking,
            Deposit
        }

        public struct BankAccount
        {
            public long accNo;
            public decimal accBal;
            public AccountType accType;
        }

        static void Main(string[] args)
        {
            BankAccount goldAccount;
            goldAccount.accType = AccountType.Checking;
            goldAccount.accBal = 3200.00M;
            goldAccount.accNo = 123;

            Console.WriteLine("***Account summary***");
            Console.WriteLine("Account number {0}", goldAccount.accNo);
            Console.WriteLine("Account balance {0}", goldAccount.accBal);
            Console.WriteLine("Account type {0}", goldAccount.accType);

        }
    }
}
