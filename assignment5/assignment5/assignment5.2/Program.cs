namespace assignment5._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string str = Console.ReadLine();

            for (int i = str.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(str[i]);
            }

            Console.ReadKey();
        }
    }
}
