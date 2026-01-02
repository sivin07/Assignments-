namespace assignment4._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of elements: ");
            int size = Convert.ToInt32(Console.ReadLine());

            if (size < 2)
            {
                Console.WriteLine("Array must contain at least two elements.");
                return;
            }

            int[] arr = new int[size];

            Console.WriteLine("Enter the elements:");
            for (int i = 0; i < size; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            int smallest = arr[0];
            int secondSmallest = int.MaxValue;

            for (int i = 0; i < size; i++)
            {
                if (arr[i] < smallest)
                {
                    secondSmallest = smallest;
                    smallest = arr[i];
                }
                else if (arr[i] > smallest && arr[i] < secondSmallest)
                {
                    secondSmallest = arr[i];
                }
            }

            Console.WriteLine("Second smallest element: " + secondSmallest);
            Console.ReadKey();
        }
    }
}
