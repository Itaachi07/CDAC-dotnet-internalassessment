using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment
{
    public class Manager : Employee
    {
        private double _performanceBonus;

        public double performanceBonus
        {   
            get { return _performanceBonus; }
            set { _performanceBonus = value; }
        }

        protected override void acceptEmployee()
        {
            Console.WriteLine("Enter Employee Name : ");
            name = Console.ReadLine();
            Console.WriteLine("Enter Depatment ID :");
            deptID = Console.ReadLine();
            Console.WriteLine("Enter Employee basic salary :");
            basic = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Performance bonus : ");
            performanceBonus = Convert.ToDouble(Console.ReadLine());  
        }

        protected override double computeNetSalary()
        {
            return (basic + performanceBonus);
        }

        public Manager()
        {
            acceptEmployee();
        }

        public override string ToString()
        {
            return "[Manager Id = " + id + ", Name = " + name + ", Department = " + deptID + ", " +
                "Net Salary = " + computeNetSalary() + ", Performance Bonus = " + performanceBonus + "]";

        }
    }
}
