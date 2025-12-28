

namespace Assignment2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your roll no:");
            int rollNo=int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your Name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter the mark of  first subject");
            int mark1=int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the mark of  second subject");
            int mark2=int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the mark of third subject");
            int mark3=int.Parse(Console.ReadLine());

            int totalMark = mark1 + mark2 + mark3;
            Console.WriteLine(totalMark);
            float percentage = (totalMark / 300f) * 100;

            if (percentage >= 90)
            {
                Console.WriteLine("A+");

            }
            else  if (percentage >= 80)
            {
                Console.WriteLine("A");
            }

            else if(percentage>=70)
            {
                Console.WriteLine("B");

            }

            else if (percentage >=60)
                {
                Console.WriteLine("C");

            }

            else
            {
                Console.WriteLine("fail");
            }




            Console.Read();


        }
    }
}
