using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace openClosedPrinciples
{
    
    class Program
    {

        static void Main(string[] args)
        {

            // Create a list to store vehicles
            List<Vehicle> vehicles = new List<Vehicle>();

            // Add instances of Sedan, Boat, and Airplane to the list
            vehicles.Add(new Sedan("red"));
            vehicles.Add(new Boat("white"));
            vehicles.Add(new Airplane("yellow"));
            vehicles.Add(new Spaceship("gray"));

            // Loop through the list and run each vehicle
            foreach (var vehicle in vehicles)
            {
                vehicle.RunVehicle();
                vehicle.AdditionalInfo();
                Console.WriteLine(); // Add a newline between vehicles
            }

            Console.ReadLine();
        }
    }
}
