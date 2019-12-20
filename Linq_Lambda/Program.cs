using System;
using System.Collections.Generic;

namespace Linq_Lambda
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Employee> employee = new List<Employee>()
            {
                new Employee(1,"Jack", "Ryan",80000.55, 11.5,Title.CIO),
                new Employee(1,"Jack", "Ryan",80000.55, 11.5,Title.CIO),
                new Employee(1,"Jack", "Ryan",80000.55, 11.5,Title.CIO),
                new Employee(1,"Jack", "Ryan",80000.55, 11.5,Title.CIO),


            };
            Console.WriteLine("Hello World!");
        }
    }
}
