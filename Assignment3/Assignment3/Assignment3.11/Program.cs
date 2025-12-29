namespace Assignment3._11
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());

            int originalNum = num;
            int temp = num;
            int digits = 0;
            int sum = 0;

        
            while (temp > 0)
            {
                digits++;
                temp /= 10;
            }

            temp = num;

          
            while (temp > 0)
            {
                int digit = temp % 10;
                sum += (int)Math.Pow(digit, digits);
                temp /= 10;
            }

            if (sum == originalNum)
            {
                Console.WriteLine("The number is an Armstrong number");
            }
            else
            {
                Console.WriteLine("The number is not an Armstrong number");
            }
            Console.ReadKey();
        }
    }
}
