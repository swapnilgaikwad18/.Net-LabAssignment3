/*  Create an array of Employee objects. 
 *  Convert it to a List<Employee>.  
 *  Display all the Employees in the list.*/
namespace Collection_Question2
{
    internal class Program
    {
        class Employee
        {
            public int EmpId { get; set; }
            public string Name { get; set; }
            public int Salary { get; set; }
        }
        static void Main()
        {
            Employee[] empArr = new Employee[]
            {
                new Employee {EmpId = 101, Name = "Swapnil", Salary = 75000},
                new Employee {EmpId = 102, Name = "Sahil", Salary = 100000},
                new Employee {EmpId = 103, Name = "Swapnil", Salary = 50000}
            };

            List<Employee> empList = new List<Employee>();

            Console.WriteLine($"Details of all employees: ");
            foreach (Employee emp in empArr)
            {
                Console.WriteLine($"Employee Name: {emp.EmpId}");
                Console.WriteLine($"Employee Name: {emp.Name}");
                Console.WriteLine($"Employee Salary: {emp.Salary}");
            }
        }
    }
}