using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee(300,"nguyen","minh",1500000);
            Console.WriteLine(e.toString());
            e.setSalary(3000000);
            Console.WriteLine("id " + e.getID() + " firstName " + e.getFirstName() + " lastName " + e.getLastName() + " salary " + e.getSalary());
            Console.WriteLine(e.toString());
            Console.WriteLine(e.getAnnualSalary());
            Console.WriteLine(e.raiseSalary(10/100));
        }
    }
}
