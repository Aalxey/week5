namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount ba = new BankAccount("123456", 1000);
            Console.WriteLine($"Account Number: {ba.AccountNumber}");
            Console.WriteLine($"Initial Balance: {ba.Balance}");
            ba.Deposit(500);
            ba.Withdraw(300);
            Console.WriteLine($"Remaining Balance: {ba.Balance}");
        }
    }
}
