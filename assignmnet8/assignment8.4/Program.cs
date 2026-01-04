namespace assignment8._4
{
    internal class Program
    {
     


        // Parent  class
        class Geometry
        {
            internal int noOfSides;

            public Geometry()
            {
            }

            public Geometry(int noOfSides)
            {
                this.noOfSides = noOfSides;
            }

            
            public virtual float Area()
            {
                return 0;
            }
        }

        // child class
        class Rectangle : Geometry
        {
            internal float length;
            internal float breadth;

            public Rectangle()
            {
                noOfSides = 4;
            }

            public Rectangle(float length, float breadth)
            {
                this.length = length;
                this.breadth = breadth;
                noOfSides = 4;
            }

            // Override area method
            public override float Area()
            {
                return length * breadth;
            }
        }

        
            static void Main(string[] args)
            {
                Console.WriteLine("enter the side one:");
                float num1=float.Parse(Console.ReadLine());

                Console.WriteLine("Enter the second  number");
                float num2=float.Parse(Console.ReadLine()); 

                Rectangle rectangle1 = new Rectangle(num1, num2);

                Console.WriteLine("Number of sides: " + rectangle1.noOfSides);
                Console.WriteLine("Area of Rectangle: " + rectangle1.Area());
            }
        }

    }



