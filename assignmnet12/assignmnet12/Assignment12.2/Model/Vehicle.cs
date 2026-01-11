using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment12._2.Model
{
    public class Vehicle
    {
        public string LicenseNo { get; set; }
        public string OwnerName { get; set; }
        public string VehicleType { get; set; }

        public Vehicle(string licenseNo, string ownerName, string vehicleType)
        {
            LicenseNo = licenseNo;
            OwnerName = ownerName;
            VehicleType = vehicleType;
        }

        public void displayInfo()
        {
            Console.WriteLine("License No: " + LicenseNo);
            Console.WriteLine("Owner Name: " + OwnerName);
            Console.WriteLine("Vehicle Type: " + VehicleType);
        }
    }
}
