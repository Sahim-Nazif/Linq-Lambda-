using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq_Lambda
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Employee> employee = new List<Employee>()
            {
                new Employee(1,"Jack", "Bryan",100000.782, 11.5,Title.Manager),
                new Employee(2,"Yunis", "Sahim",840000.55, 7.5,Title.ProjectManager),
                new Employee(3,"Meena", "Dewa",750000.55, 11,Title.BusinessAnalyst),
                new Employee(4,"Shehzad", "Sahim",780000.812, 10.5,Title.systemsAnalyst),
                new Employee(5,"Ali", "Khan",680000.812, 7.5,Title.Developer),



            };
            var displayFirstNames = from emp in employee select emp;

            foreach (var emps in displayFirstNames)
            {
                Console.WriteLine(emps.firstname);
            }
        }
    }
}
