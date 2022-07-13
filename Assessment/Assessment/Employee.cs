using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment
{
    public class Employee
    {
        private int id ;
        private string name ;
        private int deptID;
        private int basic;

        public int _basic
        {
            get { return basic; }
            set { basic = value; }
        }


        public int _deptID
        {
            get { return deptID; }
            set { deptID = value; }
        }


        public int _id
        {
            get { return id ; }
            set { id  = value; }
        }

        public String _name
        {
            get { return name; }
            set { name = value; }
        }


        Employee()
        {
            Console.WriteLine("Hello.. this is Employee")
        }
    }
}
