namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Printer myPrinter = new Printer();

            myPrinter.Print("Hello, World!");       
            myPrinter.Print(2025);                  
            myPrinter.Print("Repeating message", 3);


            //For teacher part
            NepaliTeacher nepTeacher = new NepaliTeacher
            {
                Name = "Ram"
            };

            
            EnglishTeacher engTeacher = new EnglishTeacher
            {
                Name = "Sarah"
            };

            Console.WriteLine("Nepali Teacher:");
            Console.WriteLine($"Name: {nepTeacher.Name}");
            nepTeacher.Teaching();     
            nepTeacher.SalaryInfo();    

            Console.WriteLine("\nEnglish Teacher:");
            Console.WriteLine($"Name: {engTeacher.Name}");
            engTeacher.Teaching();      
            engTeacher.SalaryInfo();
        }
    }
}
