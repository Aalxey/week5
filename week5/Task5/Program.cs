using ElectronicsStoreApp;

namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ElectronicStore store = new ElectronicStore();

            Laptop myLaptop = new Laptop("Dell", 1200);
            Smartphone myPhone = new Smartphone("Samsung", 800);

            store.AddDevice(myLaptop);
            store.AddDevice(myPhone);

            store.ShowAllDeviceDetails();
        }
    }
}
