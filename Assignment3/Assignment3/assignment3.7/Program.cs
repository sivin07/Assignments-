namespace assignment3._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number that  to be checked pallindrome or not ");
            int num =int.Parse(Console.ReadLine());

            int orginalNum = num;
            int reverse = 0;

            while (num > 0)
            {
                int digit = num % 10;
                reverse = reverse * 10 + digit;
                num=num / 10;

            }

            if(orginalNum==reverse)
            {
                Console.WriteLine("the number is  a pallindrome ");

            }
            else
            {
                Console.WriteLine("the number is not a pallindrome");
            }
            Console.ReadKey();
        }
    }
}
