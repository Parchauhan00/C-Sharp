namespace Inheritance
{


    class Animal
    {
        public String name;
        public void display()
        {
            Console.WriteLine("I am Pru");
        }


    }


    class A1 : Animal
    {
        public void getName() { Console.WriteLine(" My n is " + name); }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
           // Console.WriteLine("Hello, World!");

            A1 a = new A1();
            a.display();
            a.name = "Titanbooa";
            a.getName();

        }
    }
}
