using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment
{
    public class Employee
    {
        private int myVar;

        public int MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }


        Employee()
        {
            Console.WriteLine("Hello.. this is Employee")
        }
    }
}
