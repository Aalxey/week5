using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Vehicle
    {
        public string Brand { get; set; }
        public int speed {  get; set; }

        public void start()
        {
            Console.WriteLine($"{Brand} is starting at {speed} km/h.");
        }
        public void stop() 
        {
            Console.WriteLine($"{Brand} has stopped.");
        }
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Brand: {Brand}, Speed: {speed} km/h");
        }
    }
}
