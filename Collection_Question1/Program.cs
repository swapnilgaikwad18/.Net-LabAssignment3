/*1.Declare a dictionary based collection of Employee class objects
    Accept details for Employees  in a loop. Stop accepting based on user input (yes/no)'
    Display the Employee with highest Salary
    Accept EmpNo to be searched. Display all details for that employee.
    Display details for the Nth Employee where N is a number accepted from the user.*/

namespace Collection_Question1
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
            Dictionary<int,Employee> empDict = new Dictionary<int,Employee>();
            bool stop = false;

            while (!stop)
            {
                Employee emp = new Employee();
                Console.WriteLine($"Enter details of Employee: ");
                Console.Write("Enter empId: ");
                emp.EmpId = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Name: ");
                emp.Name = Console.ReadLine();
                Console.Write("Enter Salary: ");
                emp.Salary = Convert.ToInt32(Console.ReadLine());

                empDict.Add(emp.EmpId, emp);

                Console.WriteLine("Do you want to add more employee details(yes/No): ");
                string str = Console.ReadLine();

                if(str != "yes")
                {
                    stop = true;
                }
            }
            Console.WriteLine("--------------------------------------------");
            //Employee with Highest salary
            int highSal = 0;
            Employee highSalEmp = null;

            foreach (var emp in empDict.Values)
            {
                if (emp.Salary > highSal)
                {
                    highSal = emp.Salary;
                    highSalEmp = emp;
                }
            }
            Console.WriteLine($"{highSalEmp.Name} is employee with the highest salary of {highSal}");
            Console.WriteLine("--------------------------------------------");

            //Display the details of EmpId entered by user
            Console.Write("Enter the employee Id to be searched: ");
            int empId = Convert.ToInt32(Console.ReadLine());

            Employee searchedEmp = new Employee();

            foreach (KeyValuePair<int,Employee> emp in empDict)
            {
                if (emp.Key == empId)
                {
                    searchedEmp = emp.Value;
                }
            }
            if (searchedEmp != null)
            {
                Console.WriteLine($"Details of employee whose empId is {empId}");
                Console.WriteLine($"Employee Name: {searchedEmp.Name}");
                Console.WriteLine($"Employee Salary: {searchedEmp.Salary}");
            }
            else
            {
                Console.WriteLine($"Employee with emplId {empId} not found.");
            }
            Console.WriteLine("--------------------------------------------");

            //Display details for the Nth Employee where N is a number accepted from the user.
            Console.Write("Enter the number N to get details of employee at Nth position: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Employee empAtNth = empDict.Values.ElementAt(n-1);
            Console.WriteLine($"Details of employee at {n}: ");
            Console.WriteLine($"Employee Name: {empAtNth.EmpId}");
            Console.WriteLine($"Employee Name: {empAtNth.Name}");
            Console.WriteLine($"Employee Salary: {empAtNth.Salary}");
            Console.WriteLine("--------------------------------------------");
        }
    }
}