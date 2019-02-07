using System;
using ConsoleAppAccount.Entities;
using ConsoleAppAccount.Entities.Exceptions;

namespace ConsoleAppAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            try { 
            Console.WriteLine("Enter account data: ");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Holder: ");
            string holder = Console.ReadLine();
            Console.Write("Balance: ");
            double balance = double.Parse(Console.ReadLine());
            Console.Write("Withdraw Limit: ");
            double withdraw = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Enter amount for withdraw: ");
            double amountWithdraw = double.Parse(Console.ReadLine());
            
            Account account = new Account(number, holder,balance,withdraw);

            account.WithDraw(amountWithdraw);

            Console.WriteLine(account);
            }
            catch(DomainException e) {
                Console.WriteLine("Account: " + e.Message);
            }
        }
    }
}
