using System;

namespace assignment5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string str = Console.ReadLine();

            int count = 0;

            foreach (char ch in str)
            {
                count++;
            }

            Console.WriteLine("Length of the string: " + count);
            Console.ReadKey();
        }
    }
}
