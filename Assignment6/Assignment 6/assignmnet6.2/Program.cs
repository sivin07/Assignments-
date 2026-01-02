using System.Threading.Channels;

namespace assignmnet6._2
{
    internal class Program
    {


        class Employe
        {
            internal string name;
            internal double baseSalary;
            internal int yearOfService;

            public Employe(string _names, double _baseSalaries, int yearOfServices)
            {
                this.name = _names;
                this.baseSalary = _baseSalaries;
                this.yearOfService = yearOfServices;
            }

            public double CalculateBonus()
            {
                double bonus = baseSalary * 0.05 * yearOfService;
                return bonus;
            }

            public double TotalSalary()
            {
                double totalSalary=baseSalary+CalculateBonus();
                return totalSalary;
            }

            public override string ToString()
            {
                return "Name: " + name +
                       "\nBase Salary: " + baseSalary +
                       "\nBonus: " + CalculateBonus() +
                       "\nTotal Salary: " + TotalSalary();
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Employee Name");
            string name=Console.ReadLine(); 

            Console.WriteLine("Enter Base Salary");
            double baseSalary=double.Parse(Console.ReadLine());

            Console.WriteLine("Enter year of service ");
            int yearOfService=int.Parse(Console.ReadLine());


            //object creation 
            Employe Employe1 = new Employe(name, baseSalary, yearOfService);

            Console.WriteLine("\nEmployee Details:");
            Console.WriteLine(Employe1);

            Console.ReadKey();
        }
    }
}
