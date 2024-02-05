using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace openClosedPrinciples
{
    class Boat : Vehicle
    {

        public Boat(string color) : base(color, "Boat")
        {
        }

        public override void AdditionalInfo()
        {
            base.AdditionalInfo();
            Console.WriteLine("It can float on water.");
            // Add any additional information specific to Boat here.
        }

    }
}
