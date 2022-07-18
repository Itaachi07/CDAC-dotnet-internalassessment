using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment
{
   abstract public class Employee  //Abstract  class
    {
        private int _id ;
        private string _name ;
        private string _deptID;
        private double _basic;

        public double basic
        {
            get { return _basic; }
            set { _basic = value; }
        }


        public string deptID
        {
            get { return _deptID; }
            set { _deptID = value; }
        }


        public int id
        {
            get { return _id ; }
            set { _id  = value; }
        }

        public string name
        {
            get { return _name; }
            set { _name = value; }
        }

        public Employee()
        {
            id = 0;
        }

        //Abstract  methods with no body....  body is in  derived class 
        protected abstract void acceptEmployee();
        protected abstract double computeNetSalary();
    }
}
