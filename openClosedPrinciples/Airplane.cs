using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace openClosedPrinciples
{
    class Airplane : Vehicle
    {

        public Airplane(string color) : base(color, "Airplane")
        {
        }

        public override void AdditionalInfo()
        {
            base.AdditionalInfo();
            Console.WriteLine("It can fly in the sky.");
            // Add any additional information specific to Airplane here.
        }

    }
}
