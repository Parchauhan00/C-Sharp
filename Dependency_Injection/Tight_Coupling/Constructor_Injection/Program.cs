namespace Constructor_Injection
{
    class CurrentAccount
    {
        public void PrintDetails()
        {
            Console.WriteLine("Details of Current AC");
        }
    }
    class SavingAccount {
        public void PrintDetails()
        {
            Console.WriteLine("Details of Current AC");
        }
    }

    class Account
    {
        CurrentAccount ca = new CurrentAccount();
        SavingAccount sa = new SavingAccount();

        public void PrintAccount()
        {
            ca.PrintDetails();
            sa.PrintDetails();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Account a = new Account();
            a.PrintAccount();

        }
    }
}
