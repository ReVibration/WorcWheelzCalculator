using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorcWheelzCalculator
{
    class Program
    {
        static void Main(string[] args)
        {   
            // This is the declaration of the employees details for the program
            int ID;
            string surname;
            string forename;
            char grade;
            int hoursWorked;

            //This delcares and assigns the variables need to create more employees
            bool Continue = true; // This is set to true to enable the program to run at least once
            char userContinue; // This is a temp variable to hold the users answer

            //This delcares the employee list and the pay calculator object
            PayCalculator payCalculator;
            List<Employee> employees = new List<Employee>(); // The reason why we use lists is because we don't know how long the list is

            while (Continue) // This runs the user inputing till all of the employees have been added
            {
                //This gets the employee information from the user inside the console
                Console.WriteLine("Enter ID");
                ID = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Surname");
                surname = Console.ReadLine();
                Console.WriteLine("Enter Forname");
                forename = Console.ReadLine();
                Console.WriteLine("Enter Grade (a-e)");
                grade = Convert.ToChar(Console.ReadLine());
                Console.WriteLine("Enter Hours Worked");
                hoursWorked = Convert.ToInt32(Console.ReadLine());

                //This section assigns the objects using the constructors
                Employee currentEmployee = new Employee(ID, surname, forename, grade, hoursWorked); // This creates a temp employee to get the user input
                employees.Add(currentEmployee); // Then add this employee to the list

                Console.WriteLine("Add another employee? (y/n)");
                userContinue = Convert.ToChar(Console.ReadLine());

                if (userContinue == 'y') // This filters and valides the input to the question above
                    Continue = true;
                else
                    Continue = false;
            }

            foreach (Employee currentEmployee in employees) // This loops through all od the employees
            {
                payCalculator = new PayCalculator(currentEmployee); // Create a new calculator for each employee
                payCalculator.GeneratePaySlips(); //Then finally the calculator generates the pay slip
            }
        }
    }
}
