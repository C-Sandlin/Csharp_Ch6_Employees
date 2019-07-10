using System;
using System.Collections.Generic;

namespace employees
{
    public class Company
    {

        // Some readonly properties (let's talk about gets, baby)
        public string Name { get; }
        public DateTime CreatedOn { get; }

        // Create a public property for holding a list of current employees
        public List<Employee> EmployeeList { get; set; }

        /*
            Create a constructor method that accepts two arguments:
                1. The name of the company
                2. The date it was created

            The constructor will set the value of the public properties
        */
        public Company(string name)
        {
            Name = name;
            CreatedOn = DateTime.Now;
            EmployeeList = new List<Employee>();
        }

        // Methods
        public void AddEmployeeToPayroll(Employee employee)
        {
            EmployeeList.Add(employee);
        }

        public void ListEmployees()
        {
            Console.WriteLine($"The employees are:");
            foreach (Employee employee in EmployeeList)
            {
                Console.WriteLine($"{employee.FirstName} {employee.LastName} works for {Name} as {employee.Title} since {employee.StartDate}");
            }
        }
    }

}