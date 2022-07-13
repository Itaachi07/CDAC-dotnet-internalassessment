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

    }
}
