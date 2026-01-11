using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment12._2.Model
{
    public class VehicleRegistration
    {
        Dictionary<string, Vehicle> vehicleDict = new Dictionary<string, Vehicle>();

        public void AddVehicle(Vehicle vehicle)
        {
            vehicleDict.Add(vehicle.LicenseNo, vehicle);
        }

        public void DisplayVehicleInfo(string licenseNo)
        {
            if (vehicleDict.ContainsKey(licenseNo))
            {
                Vehicle vehicle = vehicleDict[licenseNo];
                vehicle.displayInfo();
            }
            else
            {
                Console.WriteLine("Vehicle with License No: " + licenseNo + " not found.");
            }
        }
    }
}

