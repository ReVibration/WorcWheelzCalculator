using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorcWheelzCalculator
{
    class PayCalculator
    {
        //This declares the current employee
        Employee currentEmployee;

        //This method gets the current employee
        public PayCalculator (Employee currentEmployee)
        {
            this.currentEmployee = currentEmployee;
        }

        //This method calls other methodss to generate the slips and then print them to the screen
        public void GeneratePaySlips()
        {
            currentEmployee.CalculatePay();
            currentEmployee.PrintPaySlip();
        }
    }
}
