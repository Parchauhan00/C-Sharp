using System.Text;



namespace Lambda_Expression
{

    public delegate void MyDelegate(int num);
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("hello bolo");
            Console.WriteLine(sb);
            MyDelegate obj = (a) =>
            {
                
                    a += 5;
                    Console.WriteLine(a);

                };
                obj.Invoke(5);
                Console.WriteLine();
            }
    }

}
