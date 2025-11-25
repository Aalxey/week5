using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Task1
{
    internal class BankAccount
    {
        private string accountNumber;
        private double balance;

        public string AccountNumber
        {
            get { return accountNumber; }
        }

        public double Balance
        {
            get { return balance; }
            private set
            {
                if (value > 0)
                    balance = value;
                else
                    Console.WriteLine("Balance cannot be 0 or negative.");
            }
        }

        // Constructor
        public BankAccount(string accountNumber, double initialBalance)
        {
            this.accountNumber = accountNumber;
            Balance = initialBalance;
        }
        public void Deposit(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Deposit amount must be positive.");
                return;
            }

            balance += amount;
            Console.WriteLine($"Deposited {amount}. New balance: {balance}");
        }
        public void Withdraw(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Withdrawal failed: Amount must be positive.");
            }
            else if (amount > balance)
            {
                Console.WriteLine("Withdrawal failed: Insufficient balance.");
            }
            else
            {
                balance -= amount;
                Console.WriteLine($"Withdrawal successful: {amount} withdrawn. New balance: {balance}");
            }
        }
    }
}
