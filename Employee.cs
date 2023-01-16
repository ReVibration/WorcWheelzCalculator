using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorcWheelzCalculator
{
    class Employee
    {
        // This is the declaration of the employees details for the program
        int ID;
        string surname;
        string forename;
        char grade;
        int hoursWorked;

        // This is the declaration of the programs required variable for the calculations 
        float hourlyRate;
        float grossPay;
        float taxablePayLower = 0.05f; // I have assigned these values as they are not altered in the program
        float taxablePayHigher = 0.2f; // And they always stay the same 
        float taxPayable;
        float netPay;

        //This gets all of the data and sets it to the right variables 
        public Employee (int ID, string surname, string forename, char grade, int hoursWorked)
        {
            this.ID = ID;
            this.surname = surname;
            this.forename = forename;
            this.grade = grade;
            this.hoursWorked = hoursWorked;
        }

        // This methods calls all of the method need to calculate the pay slip
        public void CalculatePay()
        {
            SetHourlyRate();
            CalcGrossPay();
            CalcTax();
            CalcNetPay();
        }

        //This method will set the hourly rate depending on the grade
        private void SetHourlyRate()
        {
            switch (grade)
            {
                case 'a':
                    hourlyRate = 8.5f;
                    break;
                case 'b':
                    hourlyRate = 8f;
                    break;
                case 'c':
                    hourlyRate = 7.5f;
                    break;
                case 'd':
                    hourlyRate = 7f;
                    break;
                case 'e':
                    hourlyRate = 6.5f;
                    break;
                default: // If the grade is inputted wrong the hourly will be locked at £6.50
                    hourlyRate = 6.5f;
                    break;
            }
        }

        //This method will calculate the gross pay of the employee
        private void CalcGrossPay()
        {
            grossPay = hourlyRate * hoursWorked;
        }

        //This method will calculate pay based on the tax bands this will also calculate the tax to be paid
        private void CalcTax()
        {
            if (grossPay < 49.99f)
                taxPayable = 0;
            else if (grossPay > 50f && grossPay < 200f)
                taxPayable = taxablePayLower * grossPay;
            else if (grossPay > 200f)
                taxPayable = taxablePayHigher * grossPay;
            else
                taxPayable = 0; // Incase the gross pay is in the wrong format the tax will be set to 0
        }

        //This section will calculate the net pay
        private void CalcNetPay()
        {
            netPay = grossPay - taxPayable;
        }

        // This section will output all of the fields to the console
        public void PrintPaySlip()
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Your ID is: {0}", ID);
            Console.WriteLine("Your name is: {0} {1}", forename, surname);
            Console.WriteLine("You are a grade: {0}", grade);
            Console.WriteLine("You have worked: {0} hours", hoursWorked);
            Console.WriteLine("Your Gross Pay is: £{0}", grossPay);
            Console.WriteLine("Your Tax Paid is: £{0}", taxPayable);
            Console.WriteLine("Your Net Pay is: £{0}", netPay);
        }
    }
}
