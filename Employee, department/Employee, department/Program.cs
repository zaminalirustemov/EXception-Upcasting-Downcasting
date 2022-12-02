namespace Employee__department
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Employee employee1 = new("Namiq", 21, 750);
            Employee employee2 = new("Eli", 19, 450);
            Employee employee3 = new("Nicat", 24, 1600);
            Employee employee4 = new("Revan", 45, 2400);
            Employee employee5 = new("Kenan", 34, 900);

            Department department = new("Logistica",2);
            department.AddEmployee(employee1);
            department.AddEmployee(employee2);
            department.AddEmployee(employee3);
            department.AddEmployee(employee4);
            department.AddEmployee(employee5);

            Console.WriteLine(employee1.ToString());
            Console.WriteLine("-----------------------");
            Console.WriteLine(employee2.ToString());
            Console.WriteLine("-----------------------");
            Console.WriteLine(employee3.ToString());
            Console.WriteLine("-----------------------");
            Console.WriteLine(employee4.ToString());
            Console.WriteLine("-----------------------");
            Console.WriteLine(employee5.ToString());
            Console.WriteLine("***********************");

            Console.WriteLine("Employee in the appropriate index:");
            Console.WriteLine(department[2]);
            
        }
    }
}