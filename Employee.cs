using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Employee_Payroll_System
{

    internal class Employee
    {
        public string Name;
        public double HourlyRate;
        public double HoursWorked;
        public double GetGrossPay()
        {
            return HourlyRate * HoursWorked;
        }
    }
}
