using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Employee__department
{
    internal class Department
    {
        public Department(string name, int employeeLimit)
        {
            this.Name = name;
            this.EmployeeLimit = employeeLimit;
        }
        public string Name { get; set; }
        public int EmployeeLimit { get; set; }
        Employee[] Employees = new Employee[0];
        public Employee this[int index]
        {
            get
            {
                return Employees[index];
            }
            set
            {
                Employees[index] = value;
            }
        }

        public void AddEmployee(Employee employee)
        {
            if (Employees.Length < EmployeeLimit)
            {
                Array.Resize(ref Employees, Employees.Length + 1);
                Employees[Employees.Length - 1] = employee;

            }
            else
            {
                throw new CapacityLimitException("You exceeded the given employee limit.");
            }
        }
    }
}
