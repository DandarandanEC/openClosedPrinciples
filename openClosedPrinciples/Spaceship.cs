using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace openClosedPrinciples
{
    class Spaceship : Vehicle 
    {
        public Spaceship(string color) : base(color, "Spaceship")
        {
        }

        public override void AdditionalInfo()
        {
            base.AdditionalInfo();
            Console.WriteLine("It can fly in the outer space.");
            // Add any additional information specific to Spaceship here.
        }
    }
}
