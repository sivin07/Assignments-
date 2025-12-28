namespace assignment2._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("calculate you geometric shapes ");
            Console.WriteLine("1.Area of rectangle");
            Console.WriteLine("2.Area of Sqaure");
            Console.WriteLine("3.Area of circle ");

            Console.WriteLine("Enter your choice  ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("length of rectangle");
                    float rectLength=float.Parse(Console.ReadLine());

                    Console.WriteLine("breadth of rectangle");
                    float rectBreadth=float.Parse(Console.ReadLine());  

                    float rectArea=(rectLength*rectBreadth);
                    Console.WriteLine("the area of rectnagle"+rectArea);
                    break;

                case 2:
                    Console.WriteLine("enter  the side of the square ");
                    float squareSide=float.Parse(Console.ReadLine());

                    float squareArea=squareSide*squareSide;
                    Console.WriteLine("the area of square "+squareArea);

                    break;

                case 3:
                    Console.WriteLine("enter the radius of circle");
                    float radius=float.Parse(Console.ReadLine());

                    float circleArea =3.14f * radius * radius;
                    Console.WriteLine("The Area of circle"+circleArea);

                    break;


                     
            }
            Console.ReadKey();
        }
    }
}
