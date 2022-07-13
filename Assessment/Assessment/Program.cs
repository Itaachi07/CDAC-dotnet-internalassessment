using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice;
            do{
            Console.WriteLine("select Your choice");
            Console.WriteLine("1. Hire manager");
            Console.WriteLine("2. Hire Worker");
            Console.WriteLine("3. Display all employee");
            Console.WriteLine("4. update basic salary");
            Console.WriteLine("5. Exit");
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("manager hired");
                    break;
                    case 2:
                    Console.WriteLine("worker hired");
                    break ;
                    case 3:
                    Console.WriteLine("all empl");
                    break;
                case 4:   
                    Console.WriteLine("update");
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
