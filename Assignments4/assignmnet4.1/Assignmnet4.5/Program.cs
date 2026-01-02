namespace Assignmnet4._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of elements: ");
            int size = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[size + 1];   // extra space for new value

            Console.WriteLine("Enter elements in sorted order:");
            for (int i = 0; i < size; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Enter new value to insert: ");
            int value = Convert.ToInt32(Console.ReadLine());

            int index;

            // shift elements to make space
            for (index = size - 1; index >= 0 && arr[index] > value; index--)
            {
                arr[index + 1] = arr[index];
            }

            // insert value
            arr[index + 1] = value;

            Console.WriteLine("Array after insertion:");
            for (int i = 0; i < size + 1; i++)
            {
                Console.Write(arr[i] + " ");
            }

            Console.ReadKey();
        }
    }
}
