namespace assignment5._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first string: ");
            string str1 = Console.ReadLine();

            Console.Write("Enter second string: ");
            string str2 = Console.ReadLine();

            int i = 0;
            bool isEqual = true;

            
            while (true)
            {
                
                if (i == str1.Length && i == str2.Length)
                    break;

                //
                if (i == str1.Length || i == str2.Length || str1[i] != str2[i])
                {
                    isEqual = false;
                    break;
                }

                i++;
            }

            if (isEqual)
                Console.WriteLine("Both strings are equal");
            else
                Console.WriteLine("Strings are not equal");

            Console.ReadKey();
        }
    }
}
