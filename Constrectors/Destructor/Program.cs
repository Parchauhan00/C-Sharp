namespace Destructor
{

    class Person
    {
        public string Name;
        public int Age;


       public Person(string name,int Age)
        {
            this.Name = name;
            this.Age = Age; 
        }

        public string getname()
        {
            return this.Name;
        }
        public int getage()
        {
            return this.Age;
        }

        ~Person() {
            Console.WriteLine("Destructor chal gaya");
                }


    }

     class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("Prime",24);
            Console.WriteLine(p.getname());
            Console.WriteLine(p.getage());
            //Console.ReadLine();

                

        }
    }
}
