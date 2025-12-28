namespace Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string correctUserId = "admin";
            string correctPassword = "1234";

            int chance = 3;

            while (chance > 0)
            {
                Console.WriteLine("Enter user id");
                string userId=Console.ReadLine();

                Console.Write("Enter password ");
                string password =( Console.ReadLine());


                if (userId == correctUserId && password == correctPassword)
                        {
                    Console.WriteLine("you are login successfully");
                    break;

                }
                chance--;
                Console.WriteLine("wrong login username or password" +chance);


            }
            Console.WriteLine("Rejected after  3  wrong attempts ");
            Console.ReadKey();


        }
    }
}
