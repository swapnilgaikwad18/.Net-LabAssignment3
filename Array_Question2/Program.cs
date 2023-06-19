/*2.Create an array of Employee class objects
        Accept details for all Employees
        Display the Employee with highest Salary
        Accept EmpNo to be searched. Display all details for that employee.*/

namespace Array_Question2
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
            Console.Write("Enter the number of employee: ");
            int noOfEmp = Convert.ToInt32(Console.ReadLine());

            Employee[] arr = new Employee[noOfEmp];

            for(int i = 0 ; i<arr.Length; i++)
            {
                Employee emp = new Employee();
                Console.WriteLine($"Enter details of Employee{i+1}: ");
                Console.Write("Enter empId: ");
                emp.EmpId = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Name: ");
                emp.Name = Console.ReadLine();
                Console.Write("Enter Salary: ");
                emp.Salary = Convert.ToInt32(Console.ReadLine());

                arr[i] = emp;
            }
            Console.WriteLine("--------------------------------------------");
            //Employee with Highest salary
            int highSal = 0;
            Employee highSalEmp = null;

            foreach(Employee emp in arr)
            {
                if(emp.Salary > highSal)
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

            foreach(Employee emp in arr)
            {
                if (emp.EmpId == empId)
                {
                    searchedEmp = emp;
                }
            }
            if(searchedEmp != null)
            {
                Console.WriteLine($"Details of employee whose empId is {empId}");
                Console.WriteLine($"Employee Name: {searchedEmp.Name}");
                Console.WriteLine($"Employee Salary: {searchedEmp.Salary}");
            }
            else
            {
                Console.WriteLine($"Employee with emplId {empId} not found.");  
            }
            
        }
    }
}