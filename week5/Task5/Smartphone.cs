using ElectronicsStoreApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class Smartphone:ElectronicDevice
    {
        public Smartphone(string brand, double price) : base(brand, price) { }

        public void EnableCamera()
        {
            Console.WriteLine($"{Brand} smartphone camera is now ENABLED.");
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Smartphone Brand: {Brand}, Price: ${Price}");
        }
    }
}
