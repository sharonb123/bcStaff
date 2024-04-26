using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp
{
    class Employee:Person
    {
        private DateTime start;

        public DateTime Start
        {
            get { return start; }
            set { start = value; }
        }

        private string empNo;
        private double salary;
        public string EmpNo { get => empNo; set => empNo = value; }
        public double Salary { get => salary; set => salary = value; }
       
        public Employee(string perName, string perSurname, DateTime perDob,DateTime empStart,string employeeNo,double sal) :base(perName,perSurname,perDob)
        {
            this.Start = empStart;
            this.EmpNo = employeeNo;
            this.Salary = sal;

        }

        public Employee()
        {

        }

        public virtual void CalculateSalary()
        {
           //overide to the Lecturer and Admin Classes
        }


        public void CalculateSalaryIncrease()
        {
            int years = DateTime.Now.Year - Start.Year;
            if (years >= 5)
            {
                Salary += 150;
            }

        }
    }
}
