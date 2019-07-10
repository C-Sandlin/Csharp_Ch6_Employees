using System;

namespace employees
{
    public class Employee
    {
        // Props
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public DateTime StartDate { get; set; }



        // Constructors
        public Employee(string firstname, string lastname, string title)
        {
            FirstName = firstname;
            LastName = lastname;
            Title = title;
            StartDate = DateTime.Now;
        }
    }
}