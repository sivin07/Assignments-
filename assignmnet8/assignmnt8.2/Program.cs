namespace assignmnt8._2
{

   {
    // STEP 1: Interface
    interface IMaths
    {
        double Add();
        double Subtract();
        double Multiply();
        double Divide();
    }

    // STEP 2: Class implementing interface
    class Maths : IMaths
    {
        private double num1;
        private double num2;

        public Maths(double num1, double num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }

        public double Add()
        {
            return num1 + num2;
        }

        public double Subtract()
        {
            return num1 - num2;
        }

        public double Multiply()
        {
            return num1 * num2;
        }

        public double Divide()
        {
            if (num2 == 0)
            {
                Console.WriteLine("Division by zero not allowed");
                return 0;
            }
            return num1 / num2;
        }
    }

  
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Maths Operations");

            Console.Write("Enter first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            // Interface reference (polymorphism)
            IMaths operation1 = new Maths(num1, num2);

            Console.WriteLine("Addition: " + operation1.Add());
            Console.WriteLine("Subtraction: " + operation1.Subtract());
            Console.WriteLine("Multiplication: " + operation1.Multiply());
            Console.WriteLine("Division: " + operation1.Divide());
        }
    }
}

