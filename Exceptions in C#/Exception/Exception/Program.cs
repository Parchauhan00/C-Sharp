using System;

namespace ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //try
            //{
            //    Console.WriteLine("Enter first number:");
            //    int num1 = int.Parse(Console.ReadLine());

            //    Console.WriteLine("Enter second number:");
            //    int num2 = int.Parse(Console.ReadLine());

            //    int res = num1 / num2;
            //    Console.WriteLine("Division result: " + res);
            //}
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine("Error: Cannot divide by zero.");
            //}




            try
            {
                string s = null;
                Console.WriteLine(s.Length);
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
           









            //    Console.WriteLine("Error: Invalid input. Please enter valid numbers.");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("An unexpected error occurred: " + ex.Message);
            //}

            // Continue with the rest of the program
            Console.WriteLine("St 1");
            Console.WriteLine("St 2");
            Console.WriteLine("St 3");
        }
    }
}
