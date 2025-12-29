namespace assignment3._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter  a number  to be  checked");
            int num=int.Parse(Console.ReadLine());

            int count = 0;

            for (int i = 1; i <=num; i++)
            {
               if( num % i ==0)
                {
                    count++;

                }
            }
            if (count == 2)
            {
                Console.WriteLine("the number is prime");
            }
            else
            {
                Console.WriteLine("the number is not prime");
            }

            Console.ReadKey();  
        }
    }
}
