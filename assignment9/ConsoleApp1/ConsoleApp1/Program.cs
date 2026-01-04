namespace ConsoleApp1
{
    class Program
    {
        interface IMammals
    {
        int GetBodyTemp(string value);
    }

    // Class implementing the interface
    class Mammal : IMammals
    {
            public int input;
        public int GetBodyTemp(string value)
        {
            return input;   // simple fixed value
        }
    }

    // Program class
   
        static void Main(string[] args)
        {
            IMammals mammals1 = new Mammal();

            Console.Write("Enter value: ");
            string input = Console.ReadLine();

            Console.WriteLine("Body Temperature: " + mammals1.GetBodyTemp(input));
        }
    }
}