namespace Anynomus_Function
{

    public delegate void MyDelegate(int num);


    class Program
    {

        public static void myMethod(int a)
        {
            a += 10;
            Console.WriteLine(a);

        }
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello, World!");

            MyDelegate obj = delegate (int a)
            {

                a += 10;
                Console.WriteLine(a);
            };
            obj.Invoke(5);
            Console.ReadLine();


        }
    }
}
