using System;

namespace assignment4._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of elements: ");
            int size = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[size];

            Console.WriteLine("Enter the elements:");
            for (int i = 0; i < size; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Enter position to delete (1 to " + size + "): ");
            int pos = Convert.ToInt32(Console.ReadLine());

            if (pos < 1 || pos > size)
            {
                Console.WriteLine("Invalid position");
            }
            else
            {
                // shift elements to the left
                for (int i = pos - 1; i < size - 1; i++)
                {
                    arr[i] = arr[i + 1];
                }

                size--; // reduce size after deletion

                Console.WriteLine("Array after deletion:");
                for (int i = 0; i < size; i++)
                {
                    Console.Write(arr[i] + " ");
                }
            }

            Console.ReadKey();
        }
    }
}
