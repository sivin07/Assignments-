namespace assignmnet8._1
{

    namespace assignmnet8._1
    {
        class Rectangle
        {
            private double x;
            private double y;

            // default 
            public Rectangle()
            {
                x = 0;
                y = 0;
            }

            // parameterized
            public Rectangle(double x, double y)
            {
                this.x = x;
                this.y = y;
            }

            // setters
            public void setX(double x)
            {
                this.x = x;
            }

            public void setY(double y)
            {
                this.y = y;
            }

            // getters
            public double getX()
            {
                return x;
            }

            public double getY()
            {
                return y;
            }

            // area method
            public double getArea()
            {
                return x * y;
            }
        }

        class Program
        {
            public static void Main(string[] args)
            {

                Console.Write("Enter value of x: ");
                double x = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter value of y: ");
                double y = Convert.ToDouble(Console.ReadLine());

                // create object using parameterized constructor
                Rectangle rectangle1 = new Rectangle(x, y);

                Console.WriteLine("Area of Rectangle: " + rectangle1.getArea());
            }
        }
    }
}
