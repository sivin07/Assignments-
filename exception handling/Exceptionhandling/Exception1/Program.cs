namespace Exception1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Employee details");
            Console.WriteLine("Enter the employee age");

            try
            {
                int age = int.Parse(Console.ReadLine());

                if (age <18 || age >60)
                {
                    throw new Exception("Age not eligible");
                }

                Console.WriteLine("You are eligible for vote in an organisation");
            }
            catch (Exception ex)
            {
                Console.WriteLine("You are not eligible for vote");
                //Console.WriteLine("Reason: " + ex.Message);//
            }
            finally
            {
                Console.WriteLine("Thanks for using this application");
            }
            Console.ReadKey();
        }
    }
}
