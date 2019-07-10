using System;
using System.Collections.Generic;

namespace employees
{

    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of a company. Name it whatever you like.
            var EvilDotCom = new Company("EvilDotCom");

            var Jason = new Employee("Jason", "Collum", "Plot Generator");
            var Nate = new Employee("Nate", "Fleming", "Implementation Manager");
            var Deep = new Employee("Deep", "Patel", "The Enforcer");

            EvilDotCom.AddEmployeeToPayroll(Jason);
            EvilDotCom.AddEmployeeToPayroll(Nate);
            EvilDotCom.AddEmployeeToPayroll(Deep);


            /*
                Iterate the company's employee list and generate the
                simple report shown above
            */
            EvilDotCom.ListEmployees();
            Console.WriteLine("______________");

            try
            {
                List<int> employeeIds = new List<int>() { 0, 11, 2 };
                foreach (int id in employeeIds)
                {
                    Employee employee = EvilDotCom.GetEmployeeById(id);
                    Console.WriteLine($"Employee #{id} is {employee.FirstName} {employee.LastName}.");
                }
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Something went wrong while finding employees");
            }


        }
    }
}
