namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            Console.WriteLine("Car:");
            myCar.Display();        
            myCar.StartEngine();    
            myCar.StopEngine();     

            Console.WriteLine();

            
            Bike myBike = new Bike();
            Console.WriteLine("Bike:");
            myBike.Display();      
            myBike.StartEngine();   
            myBike.StopEngine();
        }
    }
}
