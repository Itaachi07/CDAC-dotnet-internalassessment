using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment
{
    public class Employee 
    {
        private int _id ;
        private string _name ;
        private string _deptID;
        private int _basic;

        public int basic
        {
            get { return basic; }
            set { basic = value; }
        }


        public string deptID
        {
            get { return deptID; }
            set { deptID = value; }
        }


        public int id
        {
            get { return id ; }
            set { id  = value; }
        }

        public string name
        {
            get { return name; }
            set { name = value; }
        }


        
    }
}
