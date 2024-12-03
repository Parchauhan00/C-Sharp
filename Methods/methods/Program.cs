namespace methods
{
    internal class Program
    {


         public void reverse(int[,] arr)
        {
            for (int i = 0;i<arr.GetLength(0);i++)
            {
                for(int j = 0;j < arr.GetLength(1);j++) {
                    Console.Write(arr[i, j]);
            }
                Console.WriteLine();
            } 
        }
      static public void reverse2(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j]);
                }
                Console.WriteLine();
            }
        }

       public void  printName(String s = "UnKnown")
        {
            Console.WriteLine(s);
        }

        static void Main(string[] args)
        {
           
            int[,] arr = { { 1, 2, 3 } ,{ 5, 6, 7 },{ 8, 9, 10 } };
            Program obj = new Program();
            //obj.reverse(arr);
           // Program.reverse2(arr);
           Program obj2 = new Program();
            obj2.printName("Prime");

        }
    }
}
