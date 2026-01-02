namespace assignmnet5._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string str = Console.ReadLine();

            int count = 0;
            bool inWord = false;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != ' ' && !inWord)
                {
                    count++;
                    inWord = true;
                }
                else if (str[i] == ' ')
                {
                    inWord = false;
                }
            }

            Console.WriteLine("Total number of words: " + count);
            Console.ReadKey();
        }
    }
}
