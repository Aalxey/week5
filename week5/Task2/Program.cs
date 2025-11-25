namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car
            {
                Brand = "Toyota",
                speed = 120,
                Seats = 5
            };

            Motorcycle myBike = new Motorcycle
            {
                Brand = "Honda",
                speed = 100,
                HasCarrier = true
            };

            Console.WriteLine("Car Actions:");
            myCar.start();        
            myCar.DisplayInfo();  
            myCar.stop();         

            Console.WriteLine("\nMotorcycle Actions:");
            myBike.start();        
            myBike.DisplayInfo();  
            myBike.stop();
        }
    }
}
