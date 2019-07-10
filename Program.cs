using System;

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

            EvilDotCom.ListEmployees();

            /*
                Iterate the company's employee list and generate the
                simple report shown above
            */
        }
    }
}
