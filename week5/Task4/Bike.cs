using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Bike:Vehicle
    {
        public override void StartEngine()
        {
            Console.WriteLine("Bike engine started.");
        }

        public override void StopEngine()
        {
            Console.WriteLine("Bike engine stopped.");
        }
    }
}
