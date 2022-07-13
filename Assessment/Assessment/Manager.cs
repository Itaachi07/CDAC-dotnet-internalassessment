using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment
{
    public class Manager  :  Employee
    {
        private double _performanceBonus;

        public double performanceBonus
        {   
            get { return _performanceBonus; }
            set { _performanceBonus = value; }
        }


    }
}
