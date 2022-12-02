using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

    
namespace Employee__department
{
    internal class Employee : IPerson
    {
        private static int count;
        public Employee(string name,sbyte age,double salary)
        {
            count++;
            this.Id = count;
            this.Name = name;
            this.Age = age;
            this.Salary = salary;
        }
        public int Id { get; }
        public string Name { get; set; }
        public sbyte Age { get; set; }
        public double Salary { get; set; }
        public string GetInfo()
        {
            return $"ID: {Id}\nName: {Name}\nAge: {Age}\nSalary: {Salary}";
        }

        public void ShowInfo()
        {
            Console.WriteLine(GetInfo());
        }

        public override string ToString()
        {
            return GetInfo(); 
        }
    }
}
