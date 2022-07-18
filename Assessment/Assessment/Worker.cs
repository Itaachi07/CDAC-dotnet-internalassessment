using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment
{
    public class Worker :  Employee
    {
        private int _hoursWorked;
        private double _hourlyRate;

        public double  hourlyRate
        {
            get { return _hourlyRate; }
            set { _hourlyRate = value; }
        }


        public int hoursWorked
        {
            get { return _hoursWorked; }
            set { _hoursWorked = value; }
        }

        protected override void acceptEmployee() //method to override acceptemployee method from employee class
        {
            Console.WriteLine("Enter Employee Name : ");
            name = Console.ReadLine();
            Console.WriteLine("Enter Department ID :");
            deptID = Console.ReadLine();
            Console.WriteLine("Enter Employee basic salary :");
            basic = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter hours worked : ");
            hoursWorked = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter hourly rate : ");
            hourlyRate = Convert.ToDouble(Console.ReadLine());
        }

        protected override double computeNetSalary() //method to override computenetsalary method from employee class
        {
            return (basic + (hourlyRate*hoursWorked));
        }

        public Worker()  //Default constructor
        {
            acceptEmployee();
        }

        //To convert an object to its string representation so that it is suitable for display.
        public override string ToString()  //ToString method
        {
            return "[Worker Id = " + id + ", Name = " + name + ", Department = " + deptID + ", " +
                "Net Salary = " + computeNetSalary() + ", Hourly rate = " + hourlyRate + "]";

        }
    }
}
