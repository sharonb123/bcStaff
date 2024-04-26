using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp
{
    class Person
    {
		private string name ;

		public string Name
		{
			get {   return name; }
			set { name = value; }
		}

		private string surname;

		public string Surname
		{
			get { return surname; }
			set { surname = value; }
		}

		private DateTime dob;

		public DateTime DOB
		{
			get { return dob; }
			set { dob = value; }
		}


		public Person(string perName, string perSurname, DateTime perDob)
		{
			this.Name = perName;
			this.Surname = perSurname;
			this.DOB = perDob;
		}

		public Person()
		{

		}
	   
		public override string ToString()
		{
			return $"{Name}\t{Surname}\t{DOB}";
		}
	}
}
