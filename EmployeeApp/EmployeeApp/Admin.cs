using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp
{
    class Admin : Employee
    {
            private char grade;

            public char Grade
            {
                get { return grade; }
                set { grade = value; }
            }

            public Admin(string perName, string perSurname, DateTime perDob, DateTime empStart, string employeeNo, double sal,char theGrade) : 
            base(perName, perSurname, perDob, empStart, employeeNo,sal)//Construtor inheritance
            {
                this.Grade = theGrade;
            }

            public Admin()
            {

            }

        public override void CalculateSalary( )
        {
            if(Grade.Equals('A'))
            {
                Salary = 15000;
            }
            else if (Grade.Equals('B'))
            {
                Salary = 100000;
            }
            CalculateSalaryIncrease();
            
        }

        public override string ToString()
        {
            return $"{Name}\t{Surname}\t\t{DOB.ToShortDateString()}\t{EmpNo}\t{Grade}\t{Start.ToShortDateString()}\t{Salary:C}";
        }
    }
}

