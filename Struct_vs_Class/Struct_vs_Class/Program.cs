namespace Struct_vs_Class { 

    struct Employee
{
    public int salary;
    public int age;
}

     class Program

    {
        static void Main(string[] args)
        {
           // Console.WriteLine("Hello, World!");
           Employee e = new Employee();
            e.salary = 36000;
            e.age = 25;

            Employee e2 = e;
            Employee e3 = e;

            e.age = 26;
            Console.WriteLine(e.age);
            Console.WriteLine(e2.age);


        }
    }
}
