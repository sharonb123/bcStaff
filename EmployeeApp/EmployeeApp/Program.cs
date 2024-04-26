using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp
{
    enum Menu
    {
        capture = 1,
        admins,
        exit
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Admin> admins = new List<Admin>(); // List of type Admin
            
            int stop = 0;
            do
            {
                Console.WriteLine(@"
1. Capture 
2. Display
3. Exit");
                Console.WriteLine("Make a choice from the above Menu");
                int choice = int.Parse(Console.ReadLine());
                Menu option = new Menu();
                option = (Menu)choice;
                switch (option)
                {
                    case Menu.capture:
                        string stopCapturing = " ";
                        while (stopCapturing != "x")
                        {
                            Console.WriteLine("Name:");
                            string empName = Console.ReadLine();
                            Console.WriteLine("Surname:");
                            string empSurame = Console.ReadLine();
                            Console.WriteLine("DOB:");
                            DateTime empDOB = DateTime.Parse(Console.ReadLine());
                            Console.WriteLine("Start Date:");
                            DateTime empStart = DateTime.Parse(Console.ReadLine());
                            Console.WriteLine("Employee Code:");
                            string empCode = Console.ReadLine().ToUpper();
                            if(empCode.Equals("E1"))
                            {
                                //Create Lecturer object and add it to the Lecturer list
                            }
                            else if (empCode.Equals("E2"))
                            {
                                Admin anAdmin = new Admin();
                                anAdmin.Name = empName;
                                anAdmin.Surname = empSurame;
                                anAdmin.DOB = empDOB;
                                anAdmin.Start = empStart;
                                anAdmin.EmpNo = empCode;
                                Console.WriteLine("Grade:");
                                anAdmin.Grade = char.Parse(Console.ReadLine().ToUpper());
                                anAdmin.CalculateSalary();
                                admins.Add(anAdmin);
                            }
                            Console.WriteLine("Press enter to capture another record or x to exit");
                            stopCapturing = Console.ReadLine().ToLower();
                        }
                        break;
                    case Menu.admins:
                        Console.WriteLine("________________________________________________________________________________");
                        Console.WriteLine("NAME\tSURNAME\t\tDOB\t\tCode\tGrade\tStart Date\t\tSalary ");
                        foreach (var item in admins)
                        {
                            Console.WriteLine(item);// Uses the tostring() Method in the Admin class
                        }
                        break;
                    case Menu.exit:
                        stop = 3;
                        break;
                    default:
                        break;
                }
            } while (stop != 3);
            
            Console.ReadLine();
        }
    }
}
