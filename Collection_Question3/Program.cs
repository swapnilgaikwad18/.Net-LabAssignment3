/*  Create a List<Employee>. 
 *  Convert it to an array. 
 *  Display all the array elements.*/
namespace Collection_Question3
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
            List<Employee> listEmp = new List<Employee>();
            listEmp.Add(new Employee { EmpId = 101, Name = "Swapnil", Salary = 45000});
            listEmp.Add(new Employee { EmpId = 102, Name = "Sahil", Salary = 70000});
            listEmp.Add(new Employee { EmpId = 103, Name = "Pratik", Salary = 90000});

            Employee[] empArr = listEmp.ToArray();

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