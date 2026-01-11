namespace Exceptionhandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ente the first NUmber ");
            int num1=int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number ");
            int num2=int.Parse(Console.ReadLine());


            try
            {
                float result = num1 / num2;

                Console.WriteLine("the result value=" + result);
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("no  zero is allowed");

           

            }
            finally
            {
                Console.WriteLine("thank you for using ");


            }




            Console.WriteLine("Hello, World!");
        }
    }
}
