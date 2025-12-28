namespace assignment2._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome  to admisiion checking portal ");

            Console.WriteLine("Enter your  maths mark");
            float mathMark=float.Parse(Console.ReadLine());

            Console.WriteLine("Enter Physics mark");
            float phyMark=float.Parse(Console.ReadLine());

            Console.WriteLine("Enter Chemistry mark");
            float chemMark=float.Parse(Console.ReadLine()); 

             float totalMark=mathMark+phyMark+chemMark;


            if (mathMark >= 65 && phyMark >= 55 && chemMark >= 50 && totalMark >= 140)
            {
                Console.WriteLine("you  are eligible  for admiison ");

            }
            else
            {
                Console.WriteLine("you are not eligible for the admisison proceess");
            }
            Console.ReadKey();
        }
    }
}
