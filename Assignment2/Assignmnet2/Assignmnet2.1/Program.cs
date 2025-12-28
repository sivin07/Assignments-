namespace Assignmnet2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter age :");
            int age=int.Parse(Console.ReadLine());

            if (age>=18)
            {
                Console.WriteLine("you are elegible  for voting");

            }
            else
            {
                Console.WriteLine("You are not eligible  for voting ");
            }
            Console.ReadKey();


        }
    }
}
