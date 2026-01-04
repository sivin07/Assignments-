namespace assignmnt8._3
{
    internal class Program
    {
        float pi = (22 / 7);
        class Shape
        {
            public static float pi = 22f / 7f;

            public double radius;
            public double height;

            public Shape()
            {
                radius = 10;   
            }

            // parameterized constructor
            public Shape(double _radius, double _height)
            {
                this.radius = _radius;
                this.height = _height;
            }

           
            public double Volume()
            {
                return radius * radius * radius; 
            }

            
            public double Volume(double radius)
            {
                return (4.0 / 3.0) * float.Pi * radius * radius * radius;
            }

           
            public double Volume(double radius, double height)
            {
                return (1.0 / 3.0) * Math.PI * radius * radius * height;
            }

          
            public double Volume(double radius, double height, bool cylinder)
            {
                return Math.PI * radius * radius * height;
            }
        }

        static void Main(string[] args)
        {
            Shape shape1 = new Shape();

            Console.WriteLine("Choose Shape");
            Console.WriteLine("1. Cube");
            Console.WriteLine("2. Sphere");
            Console.WriteLine("3. Cone");
            Console.WriteLine("4. Cylinder");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    // default cube
                    Console.WriteLine("Volume of Cube (side = 10): " + shape1.Volume());
                    break;

                case 2:
                    Console.Write("Enter radius: ");
                    double r = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Volume of Sphere: " + shape1.Volume(r));
                    break;

                case 3:
                    Console.Write("Enter radius: ");
                    r = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter height: ");
                    double h = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Volume of Cone: " + shape1.Volume(r, h));
                    break;

                case 4:
                    Console.Write("Enter radius: ");
                    r = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter height: ");
                    h = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Volume of Cylinder: " + shape1.Volume(r, h, true));
                    break;

                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }
}
