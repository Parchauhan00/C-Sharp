using System.Linq;

namespace LinQ_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] age = { 12, 23, 21, 22, 14, 33, 20, 26, 55, 66 };

            // select *from age where age>20   // SQL
            var a = from i in age where i > 20 select i; // linQ

            foreach (int item in a)
            {
               // Console.Write(item);
            }
            var a2 = from i in age where i > 20 orderby i descending select i;
            foreach (int item in a2)
            {
              //  Console.WriteLine(item);
            }

            String[] names = { "prime", "king", "komg", "gadura" };
            var a3 = from name in names where name.Contains('k') select name;
            var a4 = from name in names where name.StartsWith('p') select name;

            foreach(String s in a4) { Console.WriteLine(s); }

        }
    }
}
