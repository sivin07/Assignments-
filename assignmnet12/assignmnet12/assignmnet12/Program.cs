using System.Collections;

namespace assignmnet12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedList phoneIndex = new SortedList(); //declaring sorted list

            Console.WriteLine("Enter number of entries you want to add:");
            int noOFEntry = int.Parse(Console.ReadLine()); //taking number of entries from user



            //taking input  from user and adding to sorted list
            for (int i = 0; i < noOFEntry; i++)
            {
                Console.WriteLine("Enter Name:");
                string name = Console.ReadLine(); //taking name from user

                Console.WriteLine("Enter Phone Number:");
                string phoneNumber = Console.ReadLine(); //taking phone number from user

                phoneIndex.Add(name, phoneNumber); //adding name and phone number to sorted list
            }

            //displaying the sorted list
            Console.WriteLine("Phone Index:---(sorted  by name)");


            foreach (DictionaryEntry entry in phoneIndex)
            {

                Console.WriteLine("Name: {0}, Phone Number: {1}", entry.Key, entry.Value);


            }
        }
    }
}
