namespace assignment7._1
{
    internal class Program
    {

        class Person
        {
            internal string name;
            internal int age;

        public void Readdata()
            {
                Console.WriteLine("Enter the  name");
                name=Console.ReadLine();

                Console.WriteLine("Enter age");
                age=int.Parse(Console.ReadLine());  


            }

            public void DisplayData()
            {
                Console.WriteLine($"the name of  person:{name}");
               
                Console.WriteLine($"the age of the person:{age}");

            }

            public override string ToString()
            {
                return "\nName of person" + name +
                        "age of the person" + age;
            }
        }


        //student class 
        class Student : Person
        {
            internal int roll;
            internal int marks;
            internal string grade;

            public void GetData()
            {
                Console.WriteLine("Enter roll number:");
                roll = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter marks:");
                marks = int.Parse(Console.ReadLine());
            }

            public void ComputeGrade()
            {
                if (marks >= 90)
                    grade = "A";
                else if (marks >= 75)
                    grade = "B";
                else if (marks >= 60)
                    grade = "C";
                else
                    grade = "Fail";
            }

            public void ShowData()
            {
                DisplayData();   // from Person
                Console.WriteLine($"Roll Number: {roll}");
                Console.WriteLine($"Marks: {marks}");
                Console.WriteLine($"Grade: {grade}");
            }
        }
        //employee data 
        class Employee : Person
        {
            internal double bp;
            internal double hr;
            internal double salary;

            public void GetData()
            {
                Console.WriteLine("Enter Basic Pay:");
                bp = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter HRA:");
                hr = double.Parse(Console.ReadLine());
            }

            public void ComputeSalary()
            {
                salary = bp + hr;
            }

            public void ShowData()
            {
                DisplayData();   // from Person
                Console.WriteLine($"Basic Pay: {bp}");
                Console.WriteLine($"HRA: {hr}");
                Console.WriteLine($"Salary: {salary}");
            }
        }




       
            static void Main(string[] args)
            {
                Console.WriteLine("STUDENT DETAILS");
                Student student1 = new Student();
                student1.Readdata();      // Person method
                student1.GetData();       // Student method
                student1.ComputeGrade();
                student1.ShowData();

                Console.WriteLine("\nEMPLOYEE DETAILS");
                Employee employee1 = new Employee();
                employee1.Readdata();      // Person method
                employee1.GetData();       // Employee method
                employee1.ComputeSalary();
                employee1.ShowData();

                Console.ReadKey();
            }


        }
    }
