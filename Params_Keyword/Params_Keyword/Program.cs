namespace Params_Keyword
{
    internal class Program
    {

        public static int add(params int[] nums)
        {
            int sum = 0;
            foreach (int i in nums)
            {
                sum += i;
            }
            return sum;


        }


        static void Main(string[] args)
        {
            // Console.WriteLine("Hello, World!");
            Console.WriteLine(add(10, 20, 20, 40));
            Console.ReadLine();




        }
    }
}
