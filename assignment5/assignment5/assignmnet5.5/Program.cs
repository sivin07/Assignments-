namespace assignmnet5._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string str = Console.ReadLine();

            int alphabets = 0, digits = 0, special = 0;

            for (int i = 0; i < str.Length; i++)
            {
                char ch = str[i];

                if ((ch >= 'A' && ch <= 'Z') || (ch >= 'a' && ch <= 'z'))
                {
                    alphabets++;
                }
                else if (ch >= '0' && ch <= '9')
                {
                    digits++;
                }
                else
                {
                    special++;
                }
            }

            Console.WriteLine("Alphabets: " + alphabets);
            Console.WriteLine("Digits: " + digits);
            Console.WriteLine("Special characters: " + special);

            Console.ReadKey();
        }
    }
}
