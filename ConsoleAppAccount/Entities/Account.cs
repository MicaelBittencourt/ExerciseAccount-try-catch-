using System.Globalization;
using ConsoleAppAccount.Entities.Exceptions;
namespace ConsoleAppAccount.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithDrawLimit { get; set; }

        public Account()
        {
        }

        public Account(int number, string holder, double balance, double withDrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithDrawLimit = withDrawLimit;
        }
        public void Deposit(double amount)
        {
            Balance += amount;
        }
        public void WithDraw(double amount)
        {
            if(Balance <=0 || Balance < amount)
            {
                throw new DomainException("Withdraw limit: Not enough balance");
            }
            if (WithDrawLimit < amount)
            {
                throw new DomainException("Withdraw limit: The amount exceeds withdraw limit");
            }
            Balance -= amount;
        }
        public override string ToString()
        {
            return "New balance: " + Balance.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
