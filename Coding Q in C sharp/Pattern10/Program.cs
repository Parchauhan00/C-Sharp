using System;

namespace PatternPrinting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter StartNumber (1-9): ");
            int startNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter NoOfRows (1-9): ");
            int noOfRows = Convert.ToInt32(Console.ReadLine());

            // Validate constraints
            if (startNumber >= 1 && startNumber <= 9 && noOfRows >= 1 && noOfRows <= 9 && startNumber + noOfRows <= 10)
            {
                for (int i = 0; i < noOfRows; i++) // Outer loop for rows
                {
                    for (int j = 1; j <= 2 * noOfRows - 1; j++) // Inner loop for columns
                    {
                        if (j >= noOfRows - i && j <= noOfRows + i) // Condition to print the number
                        {
                            Console.Write(startNumber + i);
                        }
                        else // Print '*' for other positions
                        {
                            Console.Write("*");
                        }
                    }
                    Console.WriteLine(); // New line after each row
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Ensure 1 <= StartNumber <= 9, 1 <= NoOfRows <= 9, and StartNumber + NoOfRows <= 10.");
            }
        }
    }
}
