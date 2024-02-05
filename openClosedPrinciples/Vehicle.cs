using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace openClosedPrinciples
{
    class Vehicle
    {
        public string vehicleColor { get; set; }
        public string vehicleType { get; protected set; }

        public Vehicle(string color, string type)
        {
            vehicleColor = color;
            vehicleType = type;
        }

        
        public void RunVehicle()
        {
            Console.WriteLine($"Running a {vehicleType} color {vehicleColor}");
        }

        public virtual void AdditionalInfo()
        {
            //Console.WriteLine($"This is a {vehicleColor} {vehicleType}.");
        }
    }
}
