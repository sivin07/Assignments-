namespace assignment2._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("calculator ");
            Console.WriteLine("calculator menu dashboard");
            Console.WriteLine("1.Addition");
            Console.WriteLine("2.Subtraction");
            Console.WriteLine("3.Multiplication");
            Console.WriteLine("4.Division");

            Console.Write("Enter first number");
            int firstNum=int.Parse(Console.ReadLine());

            Console.Write("Enter Second Number");
            int secondNum=int.Parse(Console.ReadLine());


            Console.WriteLine("Enter your choice ");
            int  choice=int.Parse(Console.ReadLine());


            switch (choice)
            {
                case 1:
                    float addNum = firstNum + secondNum;
                    Console.WriteLine("Addition"+addNum);
                    break;

                case 2:
                    float subNum=firstNum - secondNum;
                    Console.WriteLine("substraction"+subNum);
                    break;

                case 3:
                    float mulNum = firstNum * secondNum;
                    Console.WriteLine("Multiplication"+mulNum);

                    break;
                case 4:
                    float divNum = firstNum/secondNum;
                    Console.WriteLine("Division" + divNum);
                    break;
            }
            Console.ReadKey();


        }
    }
}
