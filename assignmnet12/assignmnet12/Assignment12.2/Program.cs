using Assignment12._2.Model;

namespace Assignment12._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            VehicleRegistration vehicleregister = new VehicleRegistration();

            Console.WriteLine("Welcome to Vehicle Registration System");
            Console.Write("Enter the number of vehicles to register: ");
            int numberOfVehicles = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfVehicles; i++)
            {
                Console.WriteLine("\nEnter the vehicle details");

                Console.Write("Enter the license no: ");
                string licenseNo = Console.ReadLine();

                Console.Write("Enter the owner name: ");
                string ownerName = Console.ReadLine();

                Console.Write("Enter the vehicle type: ");
                string vehicleType = Console.ReadLine();

                Vehicle objVehicle = new Vehicle(licenseNo, ownerName, vehicleType);
                vehicleregister.AddVehicle(objVehicle);
            }

            Console.WriteLine("\nVehicles registered successfully!");

            //  DISPLAY PART (this was missing)
            Console.Write("\nEnter license number to search: ");
            string searchLicense = Console.ReadLine();

            vehicleregister.DisplayVehicleInfo(searchLicense);

            Console.ReadKey();
        }
    }
}