namespace assignmnet9._3
{
    internal class Program
    {
        abstract class Animals
        {
            public abstract void SaySomething();
        }
        static void Main(string[] args)
        {
            Animals animal1=new Animals();

            Console.Write(animal1.SaySomething());
            Console.WriteLine("Hello, World!");
        }
    }
}
