using ElectronicsStoreApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class Laptop:ElectronicDevice
    {
        public Laptop(string brand, double price) : base(brand, price) { }

        public void TurnOnBattery()
        {
            Console.WriteLine($"{Brand} laptop battery is now ON.");
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Laptop Brand: {Brand}, Price: ${Price}");
        }
    }
}
