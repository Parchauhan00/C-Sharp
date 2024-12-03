    namespace ARRay
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int no;
            //Console.WriteLine("Enter Array Length");
            //no = int.Parse(Console.ReadLine());
            //int[] arr = new int[no];

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine("Enter your Element");
            //  //  arr[i] = int.Parse(Console.ReadLine
            //  int data = int.Parse(Console.ReadLine());
            //    arr[i] = data;
            //}

            //foreach(int i in arr) {
            //    Console.WriteLine(i);
            //}

            // Multi Dimenational array

            //int[,] arr1 = { { 1, 2, 3 }, { 3, 6, 9 } };

            //int[,] arr2 = new int[3, 4]
            //{
            //    {1,2,3,4 }, { 3,4,5,6 }, { 5,6,7,8 }
            //};

            //Console.WriteLine(arr2[2,2]);
            //Console.WriteLine(arr2.GetLength(0));

            //for(int i =0;i<arr2.GetLength(0);i++)
            //{
            //    for(int j =0;j<arr2.GetLength(1);j++)
            //    {
            //        Console.Write(arr2[i,j]);
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine("By forEach looop") ;

            //foreach(int item in arr2) {
            //    Console.Write(item);
            //}


            // Console.ReadLine();
            

            //JAGGED ARRAY     , in Jagged array row will be fixed but colum won't be fixed
            int[][] arr3 = new int[3][];
            arr3[0] = new[] { 11, 22, 33, 44, 76, 55, 78 };
            arr3[1] = new[] { 11, 22, 33, 44, 33, 55 };
            arr3[2] = new[] { 11, 22, 33, 44 };

            Console.WriteLine(arr3[0][3]);

            for (int i = 0; i < arr3.GetLength(0); i++)
            {
                for (int J = 0; J < arr3[i].Length; J++)   // using first row's length to run inner loop till last element(colum)
                {
                    Console.Write(arr3[i][J] + " ");
                }
                Console.WriteLine();

            }

            
        }
    }
}
