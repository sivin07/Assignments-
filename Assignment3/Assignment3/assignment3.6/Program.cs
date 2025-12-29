namespace assignment3._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter  a number ");
            int num = int.Parse(Console.ReadLine());

            int a = 0, b = 1;

            Console.Write("Fibonacci Series: ");

            if (num >= 1)
                Console.Write(a + " ");

            if (num >= 2)
                Console.Write(b + " ");

            for (int i = 3; i <= num; i++)
            {
                int c = a + b;
                Console.Write(c + " ");
                a = b;
                b = c;
            }
            Console.ReadKey();  
        }
    }
}
