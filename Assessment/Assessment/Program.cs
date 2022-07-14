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
            int f_id = 0;
            ArrayList arr_emp = new ArrayList();

            //Manager  manager1 = new Manager();
            //Worker worker1 = new Worker();
            int choice;
            do{
            Console.WriteLine("*****************************\n");
            Console.WriteLine("select Your choice");
            Console.WriteLine("1. Hire manager");
            Console.WriteLine("2. Hire Worker");
            Console.WriteLine("3. Display all employee");
            Console.WriteLine("4. update basic salary");
            Console.WriteLine("5. Exit\n");
            Console.WriteLine("*****************************\n");
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                       Manager manager1 = new Manager();
                        ++f_id;
                        manager1.id = f_id;
                        arr_emp.Add(manager1);

                    Console.WriteLine("Manager Hired \n\n");
                    break;

                case 2:
                        Worker worker1 = new Worker();
                        ++f_id;
                        worker1.id = f_id;
                        arr_emp.Add(worker1);
                    Console.WriteLine("worker hired \n\n");
                    break ;

                case 3:
                    Console.WriteLine("all empl \n\n");
                    break;
                case 4:   
                    Console.WriteLine("update \n\n");
                    break;
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
