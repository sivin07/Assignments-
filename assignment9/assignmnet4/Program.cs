namespace assignmnet4
{
    internal class Program
    {
        abstract class Animals
        {
            public abstract void SaySomething();
        }

        // Derived class Cat
        class Cat : Animals
        {
            public override void SaySomething()
            {
                Console.WriteLine("Cats Say Meoow");
            }
        }

        // Derived class Dog
        class Dog : Animals
        {
            public override void SaySomething()
            {
                Console.WriteLine("Dogs Say Bow Wow");
            }
        }

        // Main class
       
            static void Main(string[] args)
            {
                Animals cat = new Cat();
                Animals dog = new Dog();

                cat.SaySomething();
                dog.SaySomething();
            }
        }
    }