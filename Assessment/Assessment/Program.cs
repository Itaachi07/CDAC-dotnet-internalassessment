using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Assessment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int f_id = 0; //  id initialized for  increment  off  id 
            //use arraylist to  store data as it is growable
            ArrayList arr_emp = new ArrayList();    // creating object arr_emp of  arrayList

            //Manager  manager1 = new Manager();
            //Worker worker1 = new Worker();

            int choice;
            do{
            Console.WriteLine("*****************************\n");
            Console.WriteLine("Enter Your choice");
            Console.WriteLine("1. Hire manager");
            Console.WriteLine("2. Hire Worker");
            Console.WriteLine("3. Display all employee");
            Console.WriteLine("4. update basic salary");
            Console.WriteLine("5. Exit\n");
            Console.WriteLine("*****************************");
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                       Manager manager1 = new Manager(); //creating an object of Manager
                        ++f_id;   //preincremented id
                        manager1.id = f_id;
                        arr_emp.Add(manager1);

                    Console.WriteLine("Manager Hired \n\n");
                    break;


                case 2:
                        Worker worker1 = new Worker();  //creating an object of Worker
                        ++f_id;  //preincremented id
                        worker1.id = f_id;
                        arr_emp.Add(worker1);
                    Console.WriteLine("worker hired \n\n");
                    break ;


                case 3:
                        Console.WriteLine("All Employee List");
                        foreach (Object obj in arr_emp)
                            {
                                Employee emp = (Employee)obj;
                            Console.WriteLine(emp.ToString());

                            }
                    Console.WriteLine("All Employee List \n\n");
                    break;


                case 4:
                        Console.WriteLine("Enter Employee id which basic salary do you want to update : ");
                        int eid = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < arr_emp.Count; i++)
                        {

                            if (arr_emp[i] is Worker)
                            {
                                Worker w = (Worker)arr_emp[i];
                                if (w.id == eid)
                                {
                                    Console.WriteLine("Enter changed basic salary for " + w.id + " : ");
                                    w.basic = Convert.ToDouble(Console.ReadLine());
                                    arr_emp.RemoveAt(i);
                                    arr_emp.Insert(i, w);
                                    Console.WriteLine(w.ToString());
                                    break;
                                }
                            }
                            if (arr_emp[i] is Manager)
                            {
                                Manager m = (Manager)arr_emp[i];
                                if (m.id == eid)
                                {
                                    Console.WriteLine("Enter changed basic salary for " + m.id + " : ");
                                    m.basic = Convert.ToDouble(Console.ReadLine());
                                    arr_emp.RemoveAt(i);

                                    arr_emp.Insert(i, m);
                                    Console.WriteLine(m.ToString());
                                    break;

                                }
                            }


                        }
                        Console.WriteLine("Basic salary updated"); break;

                    default: 
                    break;
              }
                if (choice >= 5)
                    break;
             }
            while (choice != 5) ;
            Console.WriteLine("");

        }
    }
}
