using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Employee
    {
        private int id;
        private string firstName;
        private string lastName;
        private int salary;

        public Employee(int id, string firstName, string lastName, int salary)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.salary = salary;
        }
        public int getID()
        {
            return id;
        }
        public string getFirstName()
        {
            return firstName;
        }
        public string getLastName()
        {
            return lastName;
        }
        public string getName()
        {
            return   firstName +" "+ lastName + " "; 
        }
        public int getSalary()
        {
            return salary;
        }
        public void setSalary(int newSalary)
        {
            this.salary = newSalary;
        }
        public int getAnnualSalary()
        {
            return this.salary * 12;
        }
        public int raiseSalary(int percent)
        {
            this.salary += percent;
            return salary;
        }
        public string toString()
        {
            return string.Format("Employee[id ={0} , name = firstName lastName {1} , salary =  {2}",this.id,this.getName(),this.salary);
        }
    }
}
