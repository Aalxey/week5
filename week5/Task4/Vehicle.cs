using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal abstract class Vehicle
    {
        public abstract void StartEngine();
        public abstract void StopEngine();

        public void Display()
        {
            Console.WriteLine("This is a vehicle");
        }
    }
}
