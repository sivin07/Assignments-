using System;

namespace Exception2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Arithmetic Operations");

            Console.WriteLine("Enter the first number:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"Addition: {num1 + num2}");
            Console.WriteLine($"Subtraction: {num1 - num2}");
            Console.WriteLine($"Multiplication: {num1 * num2}");

            try
            {
          
                Console.WriteLine($"Division: {num1 / num2}");
            }
            catch (ArithmeticException ex)
            {
          
                Console.WriteLine("Reason: Division by zero is not allowed.");
            }
            finally
            {
                Console.WriteLine("Thank you for using this app.");
            }

            Console.ReadKey();
        }
    }
}
