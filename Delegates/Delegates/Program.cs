using static Delegates.Program;

namespace Delegates
{

    

    internal class Program
    {

        public void fun()
        {
            Console.WriteLine("Fun Body");
        }

        public delegate void mydel();

    }
      class Abc
    {
        public static void Main(string[] args)
        {

            Program p = new Program();
            mydel del = new mydel(p.fun);
            del();
            del();
        }
    }
}
