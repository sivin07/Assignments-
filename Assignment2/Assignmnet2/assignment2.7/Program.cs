

namespace assignment2._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter customer id");
            int id=int.Parse(Console.ReadLine());

            Console.WriteLine("Enter name");
            string name=Console.ReadLine();

            Console.WriteLine("Enter the electricity unit consumed");
            float unit=float.Parse(Console.ReadLine());

            if (unit <= 199)
            {
                Console.WriteLine("price =" + (1.20 * unit));

            }
            else if(unit >=200 && unit <400)
            {
                Console.WriteLine("price="+(1.50 * unit));  


            }
            else if(unit>=400 && unit<600)

            {
                Console.WriteLine("price =" + (1.80 * unit));

               
            }
            else
            {
                 Console.WriteLine("price"+(2.00f*unit));
            }


            Console.ReadKey();  
        }
    }
}
