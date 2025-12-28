
namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
        
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

           
            Console.Write("Enter width: ");
            int width = int.Parse(Console.ReadLine());

          
            for (int row = 1; row <= width; row++)
            {
                for (int column = 1; column <= row; column++)
                {
                    Console.Write(number);
                }

                Console.WriteLine(); // Move to next line
            }

            Console.ReadKey();
        }
    }
}
