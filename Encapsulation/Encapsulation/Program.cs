namespace Encapsulation
{
    class Person
    {
        private String name;
        private int age;

        public void setName(String name)
        {
            this.name = name;
        }

        public String getName()
        {
            return name;
        }

        public void setA(int ag)
        {
            this.age = ag;
        }

        public void getAge()
        {
            Console.WriteLine("Your age is :" + this.age);
        }


    }

     class Program
    {
        static void Main(string[] args)
        {
        
            Person p = new Person();
            p.setName("Prime0");
            String n = p.getName();
            Console.Write(n);
            Console.WriteLine(p.getName());
            p.setA(1);
          

        }
    }
}
