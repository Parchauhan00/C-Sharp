namespace Is_vs_As_Keyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            object a = "Prime";
            //bool check = a is string;
            //Console.WriteLine(check);
            if (a is string)
            {
                Console.WriteLine("Yes a is string");
            }
            else
            {
                Console.WriteLine("No it's not string");      
            }


        }
    }
}
