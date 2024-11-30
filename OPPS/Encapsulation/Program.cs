namespace Encapsulation
{
    class Bank
    {
        private String name;
        private int accountNo;

        public String Name
        {
            get { return name; }
            set { name = value; }
        }
        public int AccountNo
        {
            get { return accountNo; }
            set { accountNo = value; }

        }
        class Program
        {
            static void Main(string[] args)
            {
                Bank bank = new Bank();
                bank.Name = "prashant";
                bank.AccountNo = 590135;

                String n = bank.Name;
                Console.WriteLine(n);
                Console.WriteLine(bank.AccountNo);



            }
        }
    }
}
