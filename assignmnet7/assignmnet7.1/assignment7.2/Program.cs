using System.Reflection.Metadata;

namespace assignment7._2
{
    internal class Program
    {
        class Employee
        {
            internal string name;
            internal string phoneNumber;
            internal string designation;
            internal float basicPay;

            // Constructor
            public Employee(string _names, string _phoneNumbers, string _designations, float _basicPays)
            {
                name = _names;
                phoneNumber = _phoneNumbers;
                designation = _designations;
                basicPay = _basicPays;
            }

            public virtual void Display()
            {
                Console.WriteLine("Name: " + name);
                Console.WriteLine("Phone Number: " + phoneNumber);
                Console.WriteLine("Designation: " + designation);
                Console.WriteLine("Basic Pay: " + basicPay);
            }
        }

        // Derived class
        class Executive : Employee
        {
            public Executive(string _names, string _phoneNumbers, string _designations, float _basicPays)
                : base(_names, _phoneNumbers, _designations, _basicPays)
            {
            }

            public override void Display()
            {
                if (basicPay > 10000)
                {
                    Console.WriteLine("Executive Details:");
                    base.Display();
                }
                else
                {
                    Console.WriteLine("Employee is NOT eligible to be an Executive (Basic Pay ≤ 10000)");
                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter phone number:");
            string phone = Console.ReadLine();

            Console.WriteLine("Enter designation:");
            string designation = Console.ReadLine();

            Console.WriteLine("Enter basic pay:");
            float basicPay = float.Parse(Console.ReadLine());

            Executive exec = new Executive(name, phone, designation, basicPay);
            exec.Display();

            Console.ReadKey();
        }
    }
}