using System;
using System.Collections.Generic;
using System.Text;

namespace Linq_Lambda
{
   public  class Employee
    {
        private int Id;
        private string FirstName;
        private string LastName;
        private double Salary;
        private double Experience;
        public Title Title { get; set; }

        public Employee(int id, string firstname, string lastname, double salary, double experience, Title title)
        {
            Id = id;
            FirstName = firstname;
            LastName = lastname;
            Salary = salary;
            Experience = experience;
            Title = title;
        }
        public int id
        {
            get
            {
                return this.Id;
            }
            set
            {
                this.Id = value;
            }
        }
        public string firstname
        {
            get
            {
                return this.FirstName;
            }
            set
            {
                this.FirstName = value;
            }
        }
        public string lastname
        {
            get
            {
                return this.LastName;
            }
            set
            {
                this.LastName = value;
            }

        }
        public double salary
        {
            get
            {
                return this.Salary;
            }
            set
            {
                this.Salary = value;
            }
        }
        public double experience
        {
            get
            {
                return this.Experience;
            }
            set
            {
                this.Experience = value;
            }
        }
      

    }
}
