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

        protected override void acceptEmployee()
        {
            Console.WriteLine("Enter Employee Name : ");
            name = Console.ReadLine();
            Console.WriteLine("Enter Depatment ID :");
            deptID = Console.ReadLine();
            Console.WriteLine("Enter Employee basic salary :");
            basic = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter hours worked : ");
            hoursWorked = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter hourly rate : ");
            hourlyRate = Convert.ToDouble(Console.ReadLine());
        }

        protected override double computeNetSalary()
        {
            return (basic + (hourlyRate*hoursWorked));
        }

        public Worker()
        {
            acceptEmployee();
        }

        public override string ToString()
        {
            return "[Worker Id = " + id + ", Name = " + name + ", Department = " + deptID + ", " +
                "Net Salary = " + computeNetSalary() + ", Hourly rate = " + hourlyRate + "]";

        }
    }
}
