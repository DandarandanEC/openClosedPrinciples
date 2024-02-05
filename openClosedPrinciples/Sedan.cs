using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace openClosedPrinciples
{    
    class Sedan : Vehicle
    {
        public Sedan(string color) : base(color, "Sedan")
        {
        }

        public override void AdditionalInfo()
        {
            base.AdditionalInfo();
            Console.WriteLine("It has a comfortable interior.");
            // Add any additional information specific to Sedan here.
        }
    }
}
