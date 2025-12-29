using System.Diagnostics.CodeAnalysis;

namespace Assignment3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter  a number ");
            Int32 count=Int32.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = 1; i < count; i++)
            {
                int square = i * i;
                Console.WriteLine(i+" square"+square);
                sum=sum+square;
            }
            Console.WriteLine("Sum"+sum);
        }
    }
}
