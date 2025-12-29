namespace assignment3._8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int sum = 0;

            for (int i = 100; i <= 200; i++)
            {
                if (i % 9 == 0)
                {
                    count++;

                    sum += i;
                }
            }
            Console.WriteLine("count of numbers  divided by 9:" + count);
            Console.WriteLine("sum of all number divided by 9:" + sum);
            Console.ReadKey();  
        }
    }
}

