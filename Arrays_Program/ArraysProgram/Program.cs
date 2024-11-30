namespace ArraysProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {  2, 3,6, 5,1,4 };

            // Reverse Array
            //int si = 0;
            //int ei = arr.Length - 1;

            //while (si < ei)
            //{
            //    int temp = arr[si];
            //    arr[si] = arr[ei];
            //    arr[ei] = temp;
            //    si++;
            //    ei--;

            //}
            //for(int i = 0;i<arr.Length;i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}
            // Print Pairs Of Array
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    for (int j = i + 1; j < arr.Length; j++)
            //    {
            //        Console.WriteLine("(" + arr[i] + ", " + arr[j] + ")");
            //    }
            //}

            // Sub Array

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    for (int j = 0; j < arr.Length; j++)
            //    {
            //      for(int k = i;k<=j;k++)
            //        {
            //           Console.Write(arr[k]);

            //        }
            //      Console.WriteLine();
            //    }
            //}

            // Merge Sort

            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length-i - 1; j++)
                {
                    if (arr[j] > arr[j+1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j+1];
                        arr[j+1] = temp;
                    }
                }
            }

            foreach(int i in arr)
            {
                Console.WriteLine(i);
            }
        }
    }
}
