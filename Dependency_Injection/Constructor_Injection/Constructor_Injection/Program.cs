namespace Constructor_Injection
{
    public interface IAccount
    {
        void PrintDetails();

    }

    class CurrentAccount : IAccount
    {
        public void PrintDetails()
        {
            Console.WriteLine("Details Of Current AC");
        }
    }

    class SavingAccount : IAccount
    {
        public void PrintDetails()
        {
            Console.WriteLine("Details Of Saving AC");
        }
    }

    class Account
    {
        private IAccount account;

        public Account(IAccount account)
        {
            this.account = account;
        }
        public void PrintAccounts()
        {
            account.PrintDetails();
        }

        internal class Program
        {
            static void Main(string[] args)
            {
                IAccount ca = new CurrentAccount();
                Account a = new Account(ca);
                a.PrintAccounts();



                IAccount sa = new SavingAccount();
                Account b = new Account(sa);
                b.PrintAccounts();
            }
        }
    }
}
