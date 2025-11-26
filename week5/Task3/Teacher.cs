using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Teacher
    {
        public string Name { get; set; }

        public virtual void Teaching()
        {
            Console.WriteLine("Teacher teaches in English");
        }

        public void SalaryInfo()
        {
            Console.WriteLine("Salary cannot be changed by any child class.");
        }
    }
}
