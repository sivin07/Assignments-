namespace assignment9._5
{
    internal class Program
    {
        abstract class Animal
        {
            public int NoOfLegs { get; set; }
            public string Color { get; set; }

            // Abstract methods
            public abstract string Cry();
            public abstract void Fly();
            public abstract void Walk();
        }

        class Cat : Animal
        {
            public Cat()
            {
                NoOfLegs = 4;
                Color = "Black";
            }

            public override string Cry()
            {
                return "Meow";
            }

            public override void Fly()
            {
                Console.WriteLine("Cat cannot fly");
            }

            public override void Walk()
            {
                Console.WriteLine("Cat walks with " + NoOfLegs + " legs");
            }
        }

        class Dog : Animal
        {
            public Dog()
            {
                NoOfLegs = 4;
                Color = "Brown";
            }

            public override string Cry()
            {
                return "Bow Wow";
            }

            public override void Fly()
            {
                Console.WriteLine("Dog cannot fly");
            }

            public override void Walk()
            {
                Console.WriteLine("Dog walks with " + NoOfLegs + " legs");
            }
        }

        class Goat : Animal
        {
            public Goat()
            {
                NoOfLegs = 4;
                Color = "White";
            }

            public override string Cry()
            {
                return "Baa";
            }

            public override void Fly()
            {
                Console.WriteLine("Goat cannot fly");
            }

            public override void Walk()
            {
                Console.WriteLine("Goat walks with " + NoOfLegs + " legs");
            }
        }

        class Crow : Animal
        {
            public Crow()
            {
                NoOfLegs = 2;
                Color = "Black";
            }

            public override string Cry()
            {
                return "Caw Caw";
            }

            public override void Fly()
            {
                Console.WriteLine("Crow can fly up to 100 meters");
            }

            public override void Walk()
            {
                Console.WriteLine("Crow walks with " + NoOfLegs + " legs");
            }
        }

        class Chicken : Animal
        {
            public Chicken()
            {
                NoOfLegs = 2;
                Color = "Brown";
            }

            public override string Cry()
            {
                return "Cluck Cluck";
            }

            public override void Fly()
            {
                Console.WriteLine("Chicken can fly up to 5 meters");
            }

            public override void Walk()
            {
                Console.WriteLine("Chicken walks with " + NoOfLegs + " legs");
            }
        }

       
            static void Main(string[] args)
            {
            Animal cat1 = new Cat();
            Animal dog1 = new Dog();
            Animal goat1= new Goat();
            Animal crow1= new Crow();
            Animal chicken1 = new Chicken();

            cat1.Cry(); cat1.Fly(); cat1.Walk();
            dog1.Cry(); dog1.Fly(); dog1.Walk();
            goat1.Cry(); goat1.Fly(); goat1.Walk();
            crow1.Cry(); crow1.Fly(); crow1.Walk();
            chicken1.Cry(); chicken1.Fly(); chicken1.Walk();

        }
    }
    }
     